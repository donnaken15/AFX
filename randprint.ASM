
 format PE console 3.1

 use16
 align 1
 entry start
 heap 0
 stack 0

 include 'win32a.inc'

 section '' code data readable executable writeable shareable discardable notpageable
   start:
     invoke GetTickCount
     invoke srand,eax
     loopprint:
       invoke rand
       cmp al, $d
       je  loopprint
       inc [tries]
       movsx eax, al
       invoke printf,char,eax
       cmp [tries],32
       jge exit
       jmp loopprint

     exit:
       invoke ExitProcess,0

     char db '%01c'
     tries dw 0

 section '' import data readable writeable
   library kernel,'KERNEL32.DLL',\
	   msvcrt,'msvcrt.dll'
   import kernel,\
	  GetTickCount,'GetTickCount',\
	  ExitProcess,'ExitProcess'
   import msvcrt,\
	  printf,'printf',\
	  srand,'srand',\
	  rand,'rand'
