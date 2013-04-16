# bigtex -> Shows Big Text On Screen

## Description
Shows big ass white text on a cozy smoked background.  Meant for sharing quick words w those special people around you.  For Windows my friends.

Potentially handy for things like "Resuming meeting at 1pm", answering a question like 'what's your twitter?' you put up "[@noahcoad](http://twitter.com/noahcoad)", or copy/pasting some code.

## Install & Use
Follow these steps:
1.  **Download [bigtex.zip](support/bigtex.zip?raw=true)** and drop file contents somewhere handy
2.  Add a hotkey to launch the app, [here's how with AutoHotkey](http://noahcoad.com/post/646/create-a-global-hotkey-to-launch-a-program-with-autohotkey-on-windows)
3.  Hit your hotkey and start typing.  ESC exits

It does require [Microsoft .NET Framework 3.5](http://www.microsoft.com/en-us/download/details.aspx?id=22).

## Options
Edit bigtex.config to adjust:

* Font Name & Size
* Put a black box behind the text
* Change or removing the start up text
* Opacity level of the smoke background
* Enable auto pasting of clipboard text

## Credits & History
One day I was using Mac OS X on my MacBook instead of my usual Windows 7, and accidentally hit some key that did this.  It looked nice, so I made this for Windows.  I wrote it at about 2am before bed, used it in a couple meetings in the morning, then tidied it up and posted on github while waiting to board my flight that afternoon.  That means it's just a simple little thing.  It was originally bigtext, then cut the t off the end in honor of [this guy](http://en.wikipedia.org/wiki/Big_Tex).

## Screenshot
![](support/imgs/2013-04-12_2023-small.png)

## Q&A
**Q:** Why doesn't it have it's own default built-in hotkey (and I have to use AutoHotkey)?
**A:** Because implementing a global hotkey in Windows is a pain.  It would make the code several times larger.  To do it right you'd need to (1) add a system tray icon with its menus to stay resident, (2) add the Win32API global hotkey hooks, (3) provide UI or parse config settings to let the user pick their hotkey.  If you'd like to do this and submit a pull request, or mention that you really like the tool and wish it had its own hotkey, I'd be happy to add it.  p.s. AutoHotkey does all this for you already.
