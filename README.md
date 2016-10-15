# netbeans-link-open
Can install and open netbeans:// links from debugger

**This is working prototype.**

* Supports external links to source code to be be opened in netbeans 
* Brings netbeans window to the front
* Install's handler
* support silent install
* detects Netbeans instalation location

**To install handler:**
* Option 1 - run it as admin, if netbeans succesfully found, click Install
* Option 2 - run as admin: `NetbeansLinkOpen.exe install` output will be in console text
* Option 3 - run as admin: `NetbeansLinkOpen.exe install silent` - no output, exitcode currently always 0

**Link form:**

 This is testes with xdebug:
 'netbeans://open/?f=%f:%l&s=/mnt/c/&r=c:/'

* Argument f shoud be always <file>:<lineNumber>
* Argument s and r are (or shoud be) optional and its searchAndReplace function, if search string is in the top of f. 
Don't use backslashes in this arguments for path delimiters. (They will be probably working)

**Use it from another program/console**

This form currently works for me: 

NetbeansLinkOpen.exe "netbeans:///?f=c:/.../path/.../file.cpp:104&s=&r=" "c:\Program Files\NetBeans 8.2\bin\netbeans.exe"

 
