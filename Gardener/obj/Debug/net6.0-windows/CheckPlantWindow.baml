   M S B A M L   `   `   `  ����C  ?Gardener, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:GardenerGardener  5   	       Gardener.CheckPlantWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Gardener     5   	     � Title$  Check��5   	   $	��400��6   $	��450��6$    � 
ResizeMode$ CanMinimize=�60    � Icon$ plant_icon.jpg��6I   .��5	      � .+�5
   
   &   System.Windows.Controls.Calendar  -   5          Name$ WaterCalendar��5
      $
��Left=�6*   $��239,192,0,0q�6E   $	��Top=�6Z      SelectionMode$ MultipleRange=�6r    J� IsHitTestVisible$ False��6�   �� 5   
   -   5         ��Name$ PlantNameTB��5      $��Center=�6)   $��0,10,0,0q�6F   $
��Wrap=�6X   $��PlantNameTB��6l   $	��Top=�6   $	��430��6�   $��22(�6�   �� 5   
   -   5        $ PlantDescTB��5      $
��Left=�6)   $��	10,97,0,0q�6D   $
��Wrap=�6W   $��PlantDescTB��6k   $	��Top=�6~   $��69��6�   $	��384��6�   $��14(�6�   �� 5   
   -   5        $ 
WaterAmtTB��5      $
��Left=�6(   $��
10,171,0,0q�6C   $
��Wrap=�6W   $��
WaterAmtTB��6k   $	��Top=�6}   $	��181��6�   $��16(�6�   �� 5   
   -   5        $ WaterTimeTB��5      $
��Left=�6)   $��
10,239,0,0q�6D   $
��Wrap=�6X   $��WaterTimeTB��6l   $	��Top=�6   $	��181��6�   $��16(�6�   �� 5   
   -   5         ��Name$ NextMonthBT��5      $
��Next��6&   $
��Left=�65   $��365,198,0,0q�6P   $	��Top=�6e   $��49��6�   ���	#FFAAAAAA$
��Bold"�6�   
����������	#FFE9EEF26�   �� 5   
   -   5        $ PrevMonthBT��5      $��Previous��6&   $
��Left=�69   $��243,198,0,0q�6T   $	��Top=�6i   ���	#FFAAAAAA$
��Bold"�6�   ���	#FFFDFDFE���	#FFE6ECF16�   �� 5   
   -   5        $ TodayDateTB��5      $
��Left=�6)   $��
10,316,0,0q�6D   $
��Wrap=�6X   $��TodayDateTB��6l   $	��Top=�6   $	��192��6�   �� 5   
   -	   5        $ TimeToWaterTB��5      $
��Left=�6+   $��
10,337,0,0q�6F   $
��Wrap=�6Z   $��TimeToWaterTB��6n   $	��Top=�6�   5      5      