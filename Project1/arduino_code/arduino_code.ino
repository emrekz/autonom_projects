#include <EEPROM.h>

int value;
char UID_arr[10] = "AI28SF81KA5";
char UID_res_arr[10];

void setup()
{
  Serial.begin(9600);
  for(int i=0;i<10;i++){
    EEPROM.write(i, UID_arr[i]);
    UID_res_arr[i] = EEPROM.read(i);
  }
  
}

void loop()
{
  for(int n=0;n<10;n++){
    Serial.print(UID_res_arr[n]);
  }
  Serial.println();

  delay(1500);
}
