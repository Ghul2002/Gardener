   M S B A M L   `   `   `  ����C  ?Gardener, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:GardenerGardener  5   	       Gardener.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Gardener     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ CanMinimize=�65    � Icon$ plant_icon.jpg��6N   .��5	      � ��5
   
   �� 5       �� ImageSource$* $/Image by kjpargetera on Freepik.jpg��6   .+�5   
   �� -   5         ��Name$ 
AddPlantBT��5      $��Add new plant��6%   $
��Left=�6=   $��400,123,0,0q�6X   $	��Top=�6m   $��48��6�   $	��120��6�    J� RenderTransformOrigin$ 0.535,0.507&�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ 	PlantList��5      $��50,123,438,147q�6%   $	��NaN��6=   $	��NaN��6J    �� DisplayMemberPath$
 Name��6V   ���	#FFC2D2C66o   �� 5   
   -   5        $ CheckPlantBT��5      $��Check plant��6'   $
��Left=�6=   $��400,239,0,0q�6X   $	��Top=�6m   $��48��6�   $	��120��6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $��	50,99,0,0q�6/   $
��Wrap=�6B   $��Plant list:��6V   $	��Top=�6i   $��87��6�   $��18(�6�   �� 5   
   $��GARDENER��6   $
��Left=�6#   $��	10,10,0,0q�6>   $	��Top=�6Q   $��48(�6i   $��Arial Rounded MT Bold)�6w   �� 5   
   $
��Left=�6   $��
298,47,0,0q�6/   $
��Wrap=�6C   $��	ver. 1.0.��6W   $	��Top=�6h   �� 5   
   -   5         ��Name$ OldestPlantTB��5      $
��Left=�6+   $��601,123,0,0q�6F   $
��Wrap=�6[   $��OldestPlantTB (WIP)��6o   $	��Top=�6�   $��16(�6�   �� 5   
   -   5        $ EditPlantBT��5      $��Edit existing plant��6&   $
��Left=�6D   $��400,181,0,0q�6_   $	��Top=�6t   $��48��6�   $	��120��6�   $ 0.535,0.507&�6�   6�   �� 5   
   -   5        $ DeleteBT��5      $��Delete��6#   $
��Left=�64   $��400,301,0,0q�6O   $	��Top=�6d   $	��120��6�   5      5      