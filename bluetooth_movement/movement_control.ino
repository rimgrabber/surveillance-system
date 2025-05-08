## connect the 2nd hc-05 module for movement_control 
## install arduino car app from playstore or appstore to control it

char command;

void setup() {
  Serial.begin(9600);
  pinMode(8, OUTPUT); // Motor A
  pinMode(9, OUTPUT); // Motor B
}

void loop() {
  if (Serial.available()) {
    command = Serial.read();
    switch (command) {
      case 'F':
        digitalWrite(8, HIGH);
        digitalWrite(9, HIGH);
        break;
      case 'B':
        digitalWrite(8, LOW);
        digitalWrite(9, LOW);
        break;
      case 'L':
        digitalWrite(8, LOW);
        digitalWrite(9, HIGH);
        break;
      case 'R':
        digitalWrite(8, HIGH);
        digitalWrite(9, LOW);
        break;
    }
  }
}
