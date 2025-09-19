#include <Servo.h>
#include <Stepper.h>

int foco=4;
int puerta=8;
int cochera1=7;
int cochera2=2;
Servo myservo;

const int PPR = 200;
Stepper miMotor(PPR, 9, 10, 11, 6);

void setup() {
  // put your setup code here, to run once:
pinMode(foco,OUTPUT);
pinMode(puerta,OUTPUT);
pinMode(cochera1,OUTPUT);
pinMode(cochera2,OUTPUT);
myservo.attach(puerta);
miMotor.setSpeed(60);
Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
if (Serial.available()>0)
{
  char lectura =Serial.read();
  switch (lectura)
  {
    case '0':digitalWrite(foco,LOW); break;  
    case '1':digitalWrite(foco,HIGH); break;
    case '2': myservo.write(90); break;
    case '3': myservo.write(0); break;
    case '4':miMotor.step(PPR*3);break;
    case '8':miMotor.step(-PPR*3);break;
  }
}
}
