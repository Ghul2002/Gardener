   M S B A M L   `   `   `  ����C  ?Gardener, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:GardenerGardener  5   	       Gardener.EditPlantWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Gardener     5   	     � Title$
  Edit��5   	   $	��400��6   $	��450��6#    � 
ResizeMode$ CanMinimize=�6/    � Icon$ plant_icon.jpg��6H   .��5	      � $	��NaN��6   $��0,0,0,-6q�6   .+�5
   
   �� $
��Left=�6   $��	10,19,0,0q�6/   $
��Wrap=�6B   $��Edit your plant!��6V   $	��Top=�6n   $��36(�6�   $��Arial Black)�6�   $��42��6�   $	��335��6�   �� 5   
   $
��Left=�6   $��	27,77,0,0q�6/   $
��Wrap=�6B   $��Name: ��6V   $	��Top=�6d   $��14(�6|   �� 5   
   $
��Left=�6   $��
27,124,0,0q�6/   $
��Wrap=�6C   $��Short decription: ��6W   $	��Top=�6q   $��14(�6�   �� 5   
   $
��Left=�6   $��
27,171,0,0q�6/   $
��Wrap=�6C   $��Water amount (ml): ��6W   $	��Top=�6r   $��14(�6�   �� 5   
   $
��Left=�6   $��
27,220,0,0q�6/   $
��Wrap=�6C   $3��-How often should the plant be watered? (Days)��6W   $	��Top=�6�   $��14(�6�   �� 5   
   -   5         ��Name$ nameTB��5      $
��Left=�6"   $��
27,101,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��160��6�    �� 	MaxLength$ 20��6�   �� 5   
   -   5        $ descTB��5      $
��Left=�6"   $��
27,148,0,0q�6=   $
 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��375��6�   $ 50��6�   �� 5   
   -   5         ��Name$ 
WaterAmtCB��5      $
��Left=�6'   $��
27,195,0,0q�6B   $	��Top=�6V   $	��116��6n   $��22��6z   �� 5   
   -   5        $ WaterDaysCB��5      $
��Left=�6(   $��
27,244,0,0q�6C   $	��Top=�6W   $	��116��6o   $��22��6{   �� 5   
   -   5         ��Name$ BackBT��5      $
��Back��6!   $
��Left=�60   $��
46,295,0,0q�6K   $	��Top=�6_   $��90��6w   $��16(�6�   $��30��6�   ���	#FFEAEAEA6�   �� 5   
   -   5        $ EditPlantButton��5      $
��Edit��6*   $
��Left=�69   $��312,295,0,0q�6T   $	��Top=�6i   $��90��6�   $��16(�6�   $��30��6�   6�   �� 5   
   $
��Left=�6   $��51��6+   $��
308,10,0,0q�67   $	��Top=�6K   $��64��6c   $��/plant_icon.jpg��6n   5      5      