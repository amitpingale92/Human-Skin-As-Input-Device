/**************************************************************************************************
Last Update: 13th Nov 2007
Aim: This Contains Various Functions for Displaying on LCD 
**************************************************************************************************/
//-------------------------------------------------------------------------------------------------
#ifndef __LCD_H__
#define __LCD_H__

#define	RS		P3_4			//registor select
#define RW		P3_5			//read/_write 
#define E			P3_6			//enable
#define DATA	P1				//data lines
#define STS		P1_7			//d7th bit 

#pragma SAVE
#pragma REGPARMS
extern void SetLCD(void);		//initiates LCD
extern void LCD(unsigned char L);//0-clear display, 1-Line 1, 2-Line 2 
extern char putchar(char);		//prints single character on LCD
#pragma RESTORE

#endif
