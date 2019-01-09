#red LED
import RPi.GPIO as GPIO
import time
GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(21,GPIO.OUT)
print ("Red LED on")
GPIO.output(21,GPIO.HIGH)
time.sleep(3)
print("LED off")
GPIO.output(21,GPIO.LOW)
time.sleep(2)

#green LED
import RPi.GPIO as GPIO
import time
GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(20,GPIO.OUT)
print ("Green LED on")
GPIO.output(20,GPIO.HIGH)
time.sleep(5)
print("LED off")
GPIO.output(20,GPIO.LOW)
time.sleep(1)

#Blue LED
import RPi.GPIO as GPIO
import time
GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(24,GPIO.OUT)
print ("Blue LED on")
GPIO.output(24,GPIO.HIGH)
time.sleep(5)
print("LED off")
GPIO.output(24,GPIO.LOW)
