from tkinter import *
win = Tk()
win.title("Spinbox")

numOption = Spinbox(rightFrame, from_1, to = 80, width=5)
numOption.pack(side = TOP)

win.mainloop()
