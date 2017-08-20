# SecondMonitorClock
Adds a clock to the second monitor

I only play PC games on my primary monitor.  During that time I couldn't see the time because that was also on the primary monitor.  I tried the whole "move the task bar to the second monitor" trick, but that didn't work because when my primary monitor turns off, Windows thinks it's down to a single monitor again and reconfigures my taskbar back to default. So I had to constantly unlock my taskbar, move it, and relock it.  

So I came up with this little bit of code.  It's a simple form that positions itself in the lower right of any second monitor it finds.  It's small enough to fit in the taskbar.  It checks every second to make sure that it's in the second monitor, so when my monitor goes to sleep and Windows reconfigures to a single monitor and then later I wake it up and go back to two, the clock automatically repositions itself.

The only control it has is a right click - if you right click on the form it will quit.  That's it.
