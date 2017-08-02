//Headers------------------------------------------------------------------------------------------
#include <stdio.h>
#include "89C51.h"
#include "Delay.h"
#include "ADC.h"
#include "Serial.h"
//Definitions--------------------------------------------------------------------------------------
#define Buzzer	P3_7
//Functions----------------------------------------------------------------------------------------
void Beep(unsigned char No,unsigned int Delay);
void ReadFlex(void);
//Variables----------------------------------------------------------------------------------------
unsigned char i,j;
unsigned int Val1,Val2,Val3,Val4,Val5,Val6,Val7,Val8;
//-------------------------------------------------------------------------------------------------
//#################################################################################################
int main (void)
{
	Beep(3,300);

	SetSerial(9600,11059200,12);
	SetADC();

	while (1)
	{
			//fetching flex data
			ReadFlex();
			
			//Sending Flex Data

			//sprintf(Temp,"\n\r%d %d %d %d %d",Val1,Val2,Val3,Val4,Val5);
			//uartPrint(0,Temp);
			
			Send('L');Send('I');Send(8);
			Send(Val1);
			Send(Val2);
			Send(Val3);
			Send(Val4);
			Send(Val5);
			Send(Val6);
			Send(Val7);
			Send(Val8);

			DelayM(50);		
	}
}
//#################################################################################################
//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
void Beep(unsigned char No,unsigned int Delay)
{
	unsigned char tNo;

	for(tNo=1;tNo<=No;tNo++)	
	{
	 	Buzzer=0;
		DelayM(Delay);
		Buzzer=1;
		DelayM(Delay);
	}
}
//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
void ReadFlex(void)
{
	Val1=0;
	for(i=0;i<10;i++)
	{
		Val1+=ReadADC(0);
	}
	Val1=Val1/10;

	Val2=0;
	for(i=0;i<10;i++)
	{
		Val2+=ReadADC(1);
	}
	Val2=Val2/10;

	Val3=0;
	for(i=0;i<10;i++)
	{
		Val3+=ReadADC(2);
	}
	Val3=Val3/10;

	Val4=0;
	for(i=0;i<10;i++)
	{
		Val4+=ReadADC(3);
	}
	Val4=Val4/10;

	Val5=0;
	for(i=0;i<10;i++)
	{
		Val5+=ReadADC(4);
	}
	Val5=Val5/10;
	
	Val6=0;
	for(i=0;i<10;i++)
	{
		Val6+=ReadADC(5);
	}
	Val6=Val6/10;

	Val7=0;
	for(i=0;i<10;i++)
	{
		Val7+=ReadADC(6);
	}
	Val7=Val7/10;
	
	Val8=0;
	for(i=0;i<10;i++)
	{
		Val8+=ReadADC(7);
	}
	Val8=Val8/10;	
	
}
//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

