#Tkinter import

from tkinter import *
import tkinter.font

#GUI definitions
win = Tk()
win.title("GUI sliders")
master = Tk()
myFont = tkinter.font.Font(family = 'Helvetica', size = 12, weight = "bold")

leftFrame = Frame(win)
leftFrame.pack(side = LEFT)
rightFrame = Frame(win)
rightFrame.pack(side = RIGHT)
midFrame = Frame(win)
midFrame.pack(side = RIGHT)

checkVal1 = IntVar()
checkVal2 = IntVar()
sliderval1 = DoubleVar()
sliderval2 = DoubleVar()
sliderval3 = DoubleVar
rad = IntVar()




def buttonPress():
    print('Slider value is {}' .format(sliderval.get()))

def checkToggle():
    print('\nCheckbox #1  #2\n          {}   {}'.format(checkVal1.get(), checkVal2.get()))

def checkRadio():
    select = "Radio button" + str(rad.get()) + "selected"
    label.config(text = select)

#closes GUI#
def close():
    win.destroy






#sliders
slider = Scale(midFrame, variable = sliderval1, from_=100.0, to=0.0, orient=HORIZONTAL)
slider.pack()
slider = Scale(midFrame, variable = sliderval2, from_=100.0, to=0.0, orient=HORIZONTAL)
slider.pack()
slider = Scale(midFrame, variable = sliderval3, from_=100.0, to=0.0, orient=HORIZONTAL)
slider.pack()





win.mainloop()
