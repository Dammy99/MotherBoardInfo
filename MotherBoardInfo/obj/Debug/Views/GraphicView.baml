   M S B A M L   `   `   `  ����J  FMotherBoardInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MotherBoardInfo.ViewsMotherBoardInfo.Views  5      G(clr-namespace:MotherBoardInfo.ViewModelsMotherBoardInfo.ViewModels  5      '    !MotherBoardInfo.Views.GraphicView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:MotherBoardInfo.Views     5      7vm(clr-namespace:MotherBoardInfo.ViewModels     5      .��5      � .+�5   
   ��    Background2#��[  6   ._�5      �� $��5q�6   .��5      ��   Background3#��[ 6   $��20q�6>   ._�5      �   � RowDefinitions  5      �� 5      $��80 �6,   �� 5      .+�5      �� $��0��6$     GPU#���  61     HeaderStyle#��[ 6N   � 5      $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6*   $��30 10 10 20q�6C   .+�5   "   �� $ Vertical=�6-   .+�5   &   ��  	 Model#���  60     SimpleTextStyle#��[ 6P   $��Right=�6y   $��10q�6�   �� 5    &     	Publisher#���  60   #��[ 6T   $��Right=�6}   $��10q�6�   �� 5!   &     	DriverVer#���  60   #��[ 6T   $��Right=�6}   $��10q�6�   �� 5"   &     Drivers#���  60   #��[ 6R   $��Right=�6{   $��10q�6�   �� 5#   &    	 	GPUMemory#��� 	 60   #��[ 6T   $��Right=�6}   $��10q�6�   �� 5$   &    
 DACType#��� 
 60   #��[ 6R   $��Right=�6{   $��10q�6�   �� 5%   &     INFFile#���  60   #��[ 6R   $��Right=�6{   $��10q�6�   �� 5&   &     
INFsection#���  60   #��[ 6U   $��Right=�6~   $��10q�6�   �� 5'   &     Date#���  60   #��[ 6O   $��Right=�6x   $��
10 10 10 0q�6�   5)   #   �� 5*   "   $ Vertical=�6-   $��	10 0 20 0q�6D   .+�5+   &   �� #��[ 6L   $
��Left=�6u   $��10q�6�   ��60   �� *	GPU.Model+6�   �� 5,   &   #��[ 6P   $
��Left=�6y   $��10q�6�   ��60   �� *GPU.Publisher+6�   �� 5-   &   #��[ 6T   $
��Left=�6}   $��10q�6�   ��60   �� *GPU.DriverVersion+6�   �� 5.   &   #��[ 6N   $
��Left=�6w   $��10q�6�   ��60   �� *GPU.Drivers+6�   �� 5/   &   #��[ 6K   $
��Left=�6t   $��10q�6�   ��60   �� *
GPU.VRAM+6�   �� 50   &   #��[ 6N   $
��Left=�6w   $��10q�6�   ��60   �� *GPU.DACType+6�   �� 51   &   #��[ 6N   $
��Left=�6w   $��10q�6�   ��60   �� *GPU.INFFile+6�   �� 52   &   #��[ 6Q   $
��Left=�6z   $��10q�6�   ��60   �� *GPU.INFSection+6�   �� 53   &   #��[ 6K   $
��Left=�6t   $��
10 10 10 0q�6�   ��60   �� *
GPU.Date+6�   55   #   56      5:      5=      5>      5@      5A      5B      5C      