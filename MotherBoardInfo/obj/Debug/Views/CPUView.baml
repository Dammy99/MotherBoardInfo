   M S B A M L   `   `   `  ����J  FMotherBoardInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MotherBoardInfo.ViewsMotherBoardInfo.Views  5      G(clr-namespace:MotherBoardInfo.ViewModelsMotherBoardInfo.ViewModels  5      #    MotherBoardInfo.Views.CPUView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:MotherBoardInfo.Views     5      7vm(clr-namespace:MotherBoardInfo.ViewModels     5      .��5      � .+�5   
   ��    Background2#��[  6   ._�5      �� $��5q�6   .��5      ��   Background3#��[ 6   $��20q�6>   ._�5      �   � RowDefinitions  5      �� 5      $��80 �6,   �� 5      �� 5      .+�5      �� $��0��6$     CPU#���  61     HeaderStyle#��[ 6N   � 5      $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $ Vertical=�6-   $��20 10q�6D   .+�5   &   ��  	 Model#���  60     SimpleTextStyle#��[ 6O   $��Right=�6x   �� 5   &     Manufacturer#���  60   #��[ 6V   $��Right=�6   �� 5   &     
ProcFamily#���  60   #��[ 6T   $��Right=�6}   �� 5   &     	SerialNum#���  60   #��[ 6S   $��Right=�6|   �� 5    &    		 Speed#��� 	 60   #��[ 6O   $��Right=�6x   �� 5!   &    
 UsedProc#��� 
 60   $��Right=�6R   ��5"   *   �� 5#   .    �� 
TargetType" ��64    �� BasedOn# [ 6K    �� Triggers 5$   2   �� 5%   6    �� Binding 6B   �� *CPU.UsedCPU+ �� Value 6b   Z� .a�5&   :   ��  �� Property � y� �� Value$ 	Collapsed=�6W   �� 5'   :    � ��$ 0��6S   5(   7   �� 5)   6    6B   �� *CPU.UsedCPU+  6b   .a�5*   :   ��  � y�$ 	Collapsed=�6W   �� 5+   :    � ��$ 0��6S   5,   7   5.   /   50   '   �� 51   &     Architecture#���  60   #��[ 6V   $��Right=�6   �� 52   &    
 Socket#���  60   #��[ 6P   $��Right=�6y   �� 53   &     L1#���  60   #��[ 6L   $��Right=�6u   �� 54   &     L2#���  60   #��[ 6L   $��Right=�6u   �� 55   &     L3#���  60   #��[ 6L   $��Right=�6u   �� 56   &     	CoreCount#���  60   #��[ 6S   $��Right=�6|   �� 57   &     LogCoreCount#���  60   #��[ 6V   $��Right=�6   �� 58   &     Virtualization#���  60   #��[ 6X   $��Right=�6�   59   #   �� 5:   "   $ Vertical=�6-   $
��0 10q�6D   .+�5;   &   �� #��[ 6K   $
��Left=�6t   ��60   �� *	CPU.Model+6t   �� 5<   &   #��[ 6R   $
��Left=�6{   ��60   �� *CPU.Manufacturer+6{   �� 5=   &   #��[ 6U   $
��Left=�6~   ��60   �� *CPU.ProcessorFamily+6~   �� 5>   &   #��[ 6R   $
��Left=�6{   ��60   �� *CPU.SerialNumber+6{   �� 5?   &   #��[ 6K   $
��Left=�6t   ��60   �� *	CPU.Speed+6t   �� 5@   &   $
��Left=�6N   ��60   �� *CPU.UsedCPU+��5A   *   �� 5B   .   " ��64   # [ 6K    5C   2   �� 5D   6    6B   �� *CPU.UsedCPU+ 6b   Z� .a�5E   :   ��  � y�$ 	Collapsed=�6W   �� 5F   :    � ��$ 0��6S   5G   7   �� 5H   6    6B   �� *CPU.UsedCPU+ 6b   Z� .a�5I   :   ��  � y�$ 	Collapsed=�6W   �� 5J   :    � ��$ 0��6S   5K   7   5M   /   5O   '   �� 5P   &   #��[ 6R   $
��Left=�6{   ��60   �� *CPU.Architecture+6{   �� 5Q   &   #��[ 6W   $
��Left=�6�   ��60   �� *CPU.SocketDescription+6�   �� 5R   &   #��[ 6M   $
��Left=�6v   ��60   �� *CPU.L1Cache+6v   �� 5S   &   #��[ 6M   $
��Left=�6v   ��60   �� *CPU.L2Cache+6v   �� 5T   &   #��[ 6M   $
��Left=�6v   ��60   �� *CPU.L3Cache+6v   �� 5U   &   #��[ 6O   $
��Left=�6x   ��60   �� *CPU.CoreCount+6x   �� 5V   &   #��[ 6V   $
��Left=�6   ��60   �� *CPU.LogicalCoreCount+6   �� 5W   &   
������� 4 0MaterialDesignDataGridCheckBoxColumnEditingStyle#��[ 6i   {�.  $
��Left=�6�   ��6/   �� *CPU.Virtuarization+6�   5X   #   5Z      5]      &   System.Windows.Controls.DataGrid  5_      ���#37566D$��20 10q�68   $��2��6G     MaterialDesignDataGrid#��[ 6T   	   AutoGenerateColumns	 .  
   
IsReadOnly
 . ��6�   �� *	CPU.Cores+��5`      �� 5a   "   .R�5b   &   �� ��.  .��5c   *   �� 5d   '   5e   #      Columns 5g      0  *System.Windows.Controls.DataGridTextColumn  5h   "   ,  &System.Windows.Controls.DataGridColumn   Header$
 Core��65      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6C      
Visibility$ Visible=�6l   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   �� *
CoreNumber+6l     5i   "   $ Usage��65   $ 70 6D   $ Visible=�6�    6O   �� *	CoreUsage+ �� StringFormat$
 {0}%��6�     5j   "   5l      5m      5n      5o      5p      5q      5r      