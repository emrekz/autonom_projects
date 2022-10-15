################################################################################
# Automatically-generated file. Do not edit!
# Toolchain: GNU Tools for STM32 (10.3-2021.10)
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../Drivers/UART/uart.c 

OBJS += \
./Drivers/UART/uart.o 

C_DEPS += \
./Drivers/UART/uart.d 


# Each subdirectory must supply rules for building sources it contributes
Drivers/UART/%.o Drivers/UART/%.su: ../Drivers/UART/%.c Drivers/UART/subdir.mk
	arm-none-eabi-gcc "$<" -mcpu=cortex-m0 -std=gnu11 -g3 -DDEBUG -DUSE_HAL_DRIVER -DSTM32F030x6 -c -I../Core/Inc -I../Drivers/STM32F0xx_HAL_Driver/Inc -I../Drivers/STM32F0xx_HAL_Driver/Inc/Legacy -I../Drivers/CMSIS/Device/ST/STM32F0xx/Include -I../Drivers/CMSIS/Include -O0 -ffunction-sections -fdata-sections -Wall -fstack-usage -MMD -MP -MF"$(@:%.o=%.d)" -MT"$@" --specs=nano.specs -mfloat-abi=soft -mthumb -o "$@"

clean: clean-Drivers-2f-UART

clean-Drivers-2f-UART:
	-$(RM) ./Drivers/UART/uart.d ./Drivers/UART/uart.o ./Drivers/UART/uart.su

.PHONY: clean-Drivers-2f-UART

