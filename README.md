PS4 Syscon Tools By Abkarino & EgyCnq:
=======================================
PS4 Syscon Tools is a free solution (software & hardware) that allow you to manipulate original PlayStation 4 Syscon chip (Renesas RL78/G13).
It consists of 2 projects:
- PS4 Syscon Tools (PC client to allow you to control your PS4 Syscon Flasher hardware).
- PS4 Syscon Flasher (Hardware flasher based currently on Teensy++ 2.0 - Teensy 4.0).

Features:
=======================================
- Syscon Flash Dumps: 
  -  Full (<50 sec). 
  -  Partial (dump any specific block or block range).
  -  NVS/SNVS only.  
Note : the read process here not use the infinty loop method that continue to dump the whole memory content and pass it to TOOL0 like some other tools we use more effecient way that can read immediately any block you want.  

- Syscon Flash Write: 
  - Full (<1.5 min). 
  - Partial (write any specific block or block range). 
  - NVS/SNVS only.    


- Syscon Flash erase: 
  - Full (<4.3 sec). 
  - Partial (erase any specific block or block range).

- Enable Syscon Debug mode: 
	- Allow you to only connect 3 wires to read/write your syscon by enabling OCD flag.
	
Note : 	The process done on the fly so no need to dump the entire syscon and apply the patch then rewrite like some other tools.

Requirements:
=======================================
What you will need ?

- Teensy++ 2.0. 
- (100 to 200)~ ohm resistor. 
- wires. 
- LQFP 64 - 100 Socket Adapter (Optional) 
- Soldering skills

Connection Digrams:
=======================================
Please refer to HW directory to check the wiring digram for your hardware.

Usage - Tutorial:
=======================================
Please refer to PS4 Syscon Tool Tutorial on the following link:
https://www.youtube.com/watch?v=Abu-M_z_I-c&t=11s

Creadit:
========================================
- droogie (https://twitter.com/droogie1xp):
	For early syscon investigations & identifying original Syscon chip arch.
	
- fail0verflow (https://twitter.com/fail0verflow):
	For initial Writeup on the syscon attack, actually without their blog we will not be able to do any syscon hacks.
	
- wildcard (https://twitter.com/VVildCard777):
	For first public implementation for the Syscon glitcher that allow us to dump our Syscon flash and also for helping us a lot during this project development.

- DarkNESmonk:
	For original SysGlitch for Arduino.
	
For Updates and Release Info:
=========================================
Please follow us on twitter:	
- Abkarino (https://twitter.com/AbkarinoMHM)
- EgyCnq (https://twitter.com/EgyCnq)

As well as subscribe to our Youtube channle for more info and tutorials:

- https://www.youtube.com/@AbkarinoMHM