   M S B A M L   `   `   `  ����J  FMotherBoardInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MotherBoardInfo.ViewsMotherBoardInfo.Views  5      G(clr-namespace:MotherBoardInfo.ViewModelsMotherBoardInfo.ViewModels  5      &     MotherBoardInfo.Views.MemoryView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:MotherBoardInfo.Views     5      7vm(clr-namespace:MotherBoardInfo.ViewModels     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      � .+�5   
   ��    Background2#��[  6   ._�5      �� $��5q�6   .��5      ��   Background3#��[ 6   $��20q�6:   ._�5      �   � RowDefinitions  5      �� 5      $��80 �6(   �� 5      $	��200 �6(   �� 5      .+�5      ��  
 Memory#���  6$     HeaderStyle#��[ 6D   � 5      $��1��6   .+�5      �� $��0��6%    �� Orientation$ 
Horizontal=�65   .+�5      �� $ Vertical=�6)   $��
20 20 5 20q�6@   .+�5   &   ��   TotaRAM#���  60     SimpleTextStyle#��[ 6Q   $��Right=�6z   $��10q�6�   �� 5   &     UsedRAM#���  60   #��[ 6Q   $��Right=�6z   $��10q�6�   �� 5    &     
VirtualMem#���  60   #��[ 6T   $��Right=�6}   $��10q�6�   �� 5!   "     FreeVirtualMem#���  6,   #��[ 6T   $��Right=�6}   $��10q�6�   5"      �� 5#      $ Vertical=�6)   $��10 20 20 20q�6@   .+�5$   "   �� #��[ 6M   $
��Left=�6v   $��10q�6�   ��6,   �� *Memory.TotalRAM+6�   �� 5%   "   #��[ 6L   $
��Left=�6u   $��10q�6�   ��6,   �� *Memory.UsedRAM+6�   �� 5&   "   #��[ 6X   $
��Left=�6�   $��10q�6�   ��6,   �� *Memory.VirtualMemoryAmount+6�   �� 5'   "   #��[ 6V   $
��Left=�6   $��10q�6�   ��6,   �� *Memory.FreeVirtualMemory+6�   5)      5*      5,      � 5-      $��2��6   $
��30 0q�6(     5.      �� 5/      $	��100 �6,   �� 50      .+�52      �� $��0��6%   $ 
Horizontal=�62   .+�53      ��  �� DisplayMemberPath$ Location��55   (   $��50��56   (   $	��150��58   (   ���#80F9D7$
��Bold"�5:   (   $��20q�5;   (   $	��Top=�64   $
��Left=�5<   (   ��53   (   �� *Memory.RAMSlots+ �� SelectedItem 54   (   �� *SelectedSlot+5<   (   �� 5=      $��0��6(   $��Amount: ��65   #��[ 6E   $��20 40q�6n   $	��Top=�6}   �� 5>      $��0��6)   $��20 40q�6[   $	��Top=�6j   #��[ 6�   ��66   �� *SelectedSlot.Amount+6�   5?      �� 5@      $��1��6%   $ 
Horizontal=�62   .+�5A      �� .+�5B   &   ��  	 Manufacturer#��� 	 60   #��[ 6V   $��20 10q�6   $	��Top=�6�   $��Right=�6�   �� 5C   "    
 
FormFactor#��� 
 6,   #��[ 6P   $��20 10q�6y   $	��Top=�6�   $��Right=�6�   �� 5D   &     	Frequency#���  60   #��[ 6S   $��20 10q�6|   $	��Top=�6�   $��Right=�6�   �� 5E   &     	SerialNum#���  60   #��[ 6S   $��20 10q�6|   $	��Top=�6�   $��Right=�6�   �� 5F   &     Type#���  60   #��[ 6N   $��20 10q�6w   $	��Top=�6�   $��Right=�6�   �� 5G   &    	 Width#���  60   #��[ 6O   $��20 10q�6x   $	��Top=�6�   $��Right=�6�   5I      �� 5J      .+�5K   "   �� #��[ 6W   $
��0 10q�6�   $	��Top=�6�   $
��Left=�6�   ��6,   �� *SelectedSlot.Manufacturer+6�   �� 5L   "   #��[ 6U   $
��0 10q�6~   $	��Top=�6�   $
��Left=�6�   ��6,   �� *SelectedSlot.FormFactor+6�   �� 5M   "   #��[ 6T   $
��0 10q�6}   $	��Top=�6�   $
��Left=�6�   ��6,   �� *SelectedSlot.Frequency+6�   �� 5N   "   #��[ 6X   $
��0 10q�6�   $	��Top=�6�   $
��Left=�6�   ��6,   �� *SelectedSlot.SericalNumber+6�   �� 5O   "   #��[ 6O   $
��0 10q�6x   $	��Top=�6�   $
��Left=�6�   ��6,   �� *SelectedSlot.Type+6�   �� 5P   "   #��[ 6P   $
��0 10q�6y   $	��Top=�6�   $
��Left=�6�   ��6,   �� *SelectedSlot.Width+6�   5R      5S      5T      5U      5W      5X      5Y      5Z      5[      