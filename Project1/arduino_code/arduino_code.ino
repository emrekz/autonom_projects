#include <EEPROM.h>

char UID_arr[10] = "AI28SF81KA5";   // created unique id.
char UID_res_arr[10];
char receivedCommand;
bool newData = false;
int UID_arr_size;

void setup()
{
  Serial.begin(9600);
  UID_arr_size = sizeof(UID_arr);
  writeToEEPROM(UID_arr);   // function write to EEPROM.
  readFromEEPROM();         // function read from EEPROM.
}

void loop()
{
  CheckSerial();
}

void CheckSerial(){   // Checking the serial port.
  if(Serial.available()>0){   // if someting received from the serial.
    receivedCommand = Serial.read();  // read received command.
    newData = true;   // set variable if new data is come.  
  }

  if(newData == true){
    if(receivedCommand == 'u'){   // if command is correct 
      for(int n=0;n<10;n++){
        Serial.print(UID_res_arr[n]);
      }
      Serial.println();
    }
  }
  newData = false;  // after the above code we reset 'newData' for ready to new commands again.
}

void writeToEEPROM(char UID_arr[]){
  for(int i=0;i<UID_arr_size;i++){
    EEPROM.write(i, UID_arr[i]);      // unique id added on to EEPROM.
  } 
}

void readFromEEPROM(){
  for(int i=0;i<UID_arr_size;i++){
    UID_res_arr[i] = EEPROM.read(i);  // reading existing data from EEPROM.
  }
}
