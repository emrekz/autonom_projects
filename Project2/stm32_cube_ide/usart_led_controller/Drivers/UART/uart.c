/*
 * uart.c
 *
 *  Created on: Oct 15, 2022
 *      Author: emrekz
 */


#include "stm32f0xx_hal.h"


/******************** UART CONFIG STEPS ********************
1- Enable the UART CLOCK and GPIO CLOCK
2- Configure the UART PINs for Alternate Functions.
3- Clear all bits in CR1
4- Program the M bit in USART_CR1 to define the word length.
5- Enable the USART by writing UE bit in USART_CR1 register to 1
6- Select the desired baud rate using the USART_BRR register.
7- Enable the Transmitter/Receiver by setting the TE and RE bits in USART_CR1 register.

***********************************************************/

void usart_config(void){
	//	1- Enable the UART CLOCK and GPIO CLOCK
	RCC->APB2ENR |= (1<<14);		//	USART1 Clock enabled.
	RCC->AHBENR |= (1<<17);			//	GPIOA Clock enabled.

	//	2- Configure the UART PINs for Alternate Functions.
	GPIOA->MODER |= (2<<4);			//	Bits [5 4] (1 0) - set PA2 alternate function.
	GPIOA->MODER |= (2<<6);			//	Bits [7 6] (1 0) - set PA3 alternate function.

	//	Configure PIN speed
	GPIOA->OSPEEDR |= (3<<4) | (3<<6);		//	Bits [5 4] (1 1) and Bits [7 6] (1 1) - Set highest speed to PA2 and PA3.

	//	Configure alternate function low and high registers.
	GPIOA->AFR[0] |= (1<<8);		//	set AFSEL2[3:0] = [0 0 0 1]
	GPIOA->AFR[0] |= (1<<12);		//	set AFSEL3[3:0] = [0 0 0 1]

	//	3- Clear all bits in CR1
	USART1->CR1 = 0x00;				//	Clear all.

	//	4- Program the M bit in USART_CR1 to define the word length.
	USART1->CR1 &= ~(1<<12);		//	Set M0 bit 0
	USART1->CR1 &= ~(1<<28);		//	Set M1 bit 0

	//	5-Enable the USART by writing UE bit in USART_CR1 register to 1
	USART1->CR1 |= (1<<0);			// 	set UE bit 1

	//	6- Select the desired baud rate using the USART_BRR register.
	USART1->BRR = 0x0341;			//	over-sampling 16 - baud rate 9600

	//	6- Enable the Transmitter/Receiver by setting the TE and RE bits in USART_CR1 register.
	USART1->CR1 |= (1<<2);			//	Set RE bit of USART_CR1 register
	USART1->CR1 |= (1<<3);			//	Set TE bit of USART_CR1 register

}



/************************ SEND CHARACTER *****************************
1. Write the data to send in USASRT_DR register (this clears the TXE bit). Repeat this
      for each data to be transmitted in case of single buffer.
2. After writing the last data into the USART_DR register wait until TC=1. This indicates
      that the transmission of the last frame is complete. This is required for instance when
      the USART is disabled or enters the halt mode to avoid corrupting the last transmission.

*********************************************************************/

void usart_send_char(uint8_t c){
	USART1->TDR = c;					//	Load data into RDR register.
	while(!(USART1->ISR & (1<<6)));		//	Wait for the TC bit is set. This indicate that the data has been transmitted.
}
