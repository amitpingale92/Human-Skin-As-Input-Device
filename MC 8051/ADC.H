/**************************************************************************************************
Last Update: 13th Nov 2007
Aim: This Contains Various Functions to Interface ADC
//************************************************************************************************/
#ifndef __ADC_H__
#define __ADC_H__

#define Data	P0					//data lines
#define	A			P2_5				//address a
#define B			P2_4				//address b
#define C			P2_3				//address c
#define ALE		P2_2				//address latch enable
#define SOC		P2_1				//start of conversion
#define EOC		P2_0				//end of conversion

#pragma SAVE
#pragma REGPARMS
extern void SetADC(void);//initalize ADC
extern unsigned char ReadADC(unsigned char ChNo); //Read data from ADC, pass channel no.
#pragma RESTORE

#endif

