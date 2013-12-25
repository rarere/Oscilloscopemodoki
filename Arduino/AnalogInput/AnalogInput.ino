int sensorPin = A0;    // select the input pin for the potentiometer
int sensorValue = 0;  // variable to store the value coming from the sensor
float fValue = 0.0;

void setup() {
  Serial.begin(9600);
}

void loop() {
  sensorValue = analogRead(sensorPin);    
  fValue = float(sensorValue) * 5.0 / 1023.0;
  
  Serial.print(sensorValue);
  Serial.print(", ");
  Serial.println(fValue);
  delay(100);
}
