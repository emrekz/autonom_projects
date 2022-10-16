String receivedData;
int delayTime = 100;
int onDelayTime = 100;
int offDelayTime = 100;
int oldOnDelayTime;
int oldOffDelayTime;
bool echoStart = false;

void setup() {
  Serial.begin(115200);
  pinMode(13, OUTPUT);
}

void loop() {
  checkSerial();
  ledControl(onDelayTime, offDelayTime);
}

void checkSerial(){
  while (Serial.available()) {    
    String receivedStr = Serial.readString();
    receivedData = receivedStr;
    
    echoStatus(receivedStr);
    
    if(echoStart){
      echo(receivedStr);
    }
    
    receivedStr.trim();                  
    int strLen = receivedStr.length();
    if(receivedStr.indexOf("ledon") >= 0){
      String delayStr = receivedStr.substring(6,50);
      onDelayTime = delayStr.toInt();
      oldOnDelayTime = onDelayTime;
    }
    else if(receivedStr.indexOf("ledoff") >= 0){
      String delayStr = receivedStr.substring(7,50);
      offDelayTime = delayStr.toInt();
      oldOffDelayTime = offDelayTime;
    }
    else if(receivedStr.indexOf("baudrate") >= 0){
      String baudrateStr = receivedStr.substring(9,50);
      Serial.flush();
      delay(500);
      Serial.begin(baudrateStr.toInt());
    }
  } 
}

void ledControl(int on, int off){
  digitalWrite(13, LOW);
  delay(off);
  digitalWrite(13, HIGH);
  delay(on);
}

void echoStatus(String statu){
  if(statu == "start"){
    echoStart = true;
    oldOnDelayTime = onDelayTime;
    oldOffDelayTime = offDelayTime;
    onDelayTime = 1000;
    offDelayTime = 1000;
  } 
  else if(statu == "stop"){
    echoStart = false;
    onDelayTime = oldOnDelayTime;
    offDelayTime = oldOffDelayTime;
  }
}

void echo(String data){
  Serial.println(data);
}
