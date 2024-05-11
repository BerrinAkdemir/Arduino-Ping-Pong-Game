int x1Pin = A0 ; 
int y1Pin = A1 ; 
int x2Pin = A2 ; 
int y2Pin = A3 ; 
int buton1Pin = 2; 
int buton2Pin = 3 ; 
int x1Pozisyon;
int y1Pozisyon;
int x2Pozisyon;
int y2Pozisyon;

int butonDurum;
int butonDurum2;

void setup() {

Serial.begin(9600);
pinMode(x1Pin, INPUT);
pinMode(y1Pin, INPUT);
pinMode(x2Pin, INPUT);
pinMode(y2Pin, INPUT);
pinMode(buton1Pin, INPUT_PULLUP);
pinMode(buton2Pin, INPUT_PULLUP);

}
void loop() {

x1Pozisyon = analogRead(x1Pin);
y1Pozisyon = analogRead(y1Pin);
x2Pozisyon = analogRead(x2Pin);
y2Pozisyon = analogRead(y2Pin);
butonDurum = digitalRead(buton1Pin);
butonDurum2 = digitalRead(buton2Pin);

Serial.print(x1Pozisyon);
Serial.print(" ");
Serial.print(y1Pozisyon);
Serial.print(" ");
Serial.print(butonDurum);
Serial.print(" ");
Serial.print(x2Pozisyon);
Serial.print(" ");
Serial.print(y2Pozisyon);
Serial.print(" ");
Serial.println(butonDurum2);
delay(100);

}