   M S B A M L   `   `   `  ����J  FMotherBoardInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MotherBoardInfoMotherBoardInfo  5   	   a5clr-namespace:MotherBoardInfo.Infrastructure.Commands'MotherBoardInfo.Infrastructure.Commands  5   	   G(clr-namespace:MotherBoardInfo.ViewModelsMotherBoardInfo.ViewModels  5   	   &     MotherBoardInfo.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MotherBoardInfo     5   	   Ecmd5clr-namespace:MotherBoardInfo.Infrastructure.Commands     5   	   7vm(clr-namespace:MotherBoardInfo.ViewModels     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   _ [Hardcodet.NotifyIcon.Wpf, Version=1.1.0.0, Culture=neutral, PublicKeyToken=682384a853a08aad)tb http://www.hardcodet.net/taskbar  5
   	     � WindowStyle$
  None=�5   	    � AllowsTransparency .  � 
ResizeMode$ 	CanResize=�5   	   
������  � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 
MainWindow��5   	   $	��300��6   $	��650��6,   $	��550��6;   $
��1000��6H    � DataContext 5      4  .MotherBoardInfo.ViewModels.MainWindowViewModel  5   
    � 	Resources 5      =  7MotherBoardInfo.Infrastructure.Commands.CloseAppCommand   CloseAppCommand<  6MotherBoardInfo.Infrastructure.Commands.MoveAppCommand  MoveAppCommandC  =MotherBoardInfo.Infrastructure.Commands.MinimizeWindowCommand  MinimizeWindowCommand@  :MotherBoardInfo.Infrastructure.Commands.SetLocalizeCommand  SetLocalizeCommandB  <MotherBoardInfo.Infrastructure.Commands.SetNormalSizeCommand  SetNormalSizeCommand��%�   &	        &	      &	 &     &	 9     &	 L       5   
   6     5   
   6     5   
   6$     5   
   6!     5   
   6#   5      '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�6   .��5      � 	 � ColumnDefinitions	 5    
   �� 5!      $	��37* �6   �� 5"      $	��13* �6   .+�5%   
   �� ���#1C2F3E
 �� CornerRadius$
 10��6&   $��2��68    J� Effect 5&      3  -System.Windows.Media.Effects.DropShadowEffect  5'         
BlurRadius$ 30Q�6#      ShadowDepth$ 2Q�5(   #      	Direction$	 -90Q�5)   #      Color$
 Gray��5*   #   5+      ._�5-      �  � RowDefinitions 5.      �� 5/      $��50 �6$   �� 50      .+�52      3	  -Hardcodet.Wpf.TaskbarNotification.TaskbarIcon	  $y�Visible=�6!    	  
IconSource$ motherboard.ico��66    	  	TrayPopup 53      � 54      ���#1F4149.+�55      ��  �� Orientation$ Vertical=�6)   $��10q�6@   .+�56   "   �� $��5q�6)     MotherboardBtn#���  64   ��6_   �� *MotherboardCommand+�� 57   "   $��5q�6)    
 CPUBtn#���  64   ��6W   �� *
CPUCommand+�� 58   "   $��5q�6)     	MemoryBtn#���  64   ��6Z   �� *MemoryCommand+�� 59   "   $��5q�6)    
 GPUBtn#���  64   ��6W   �� *
GPUCommand+5:      5;      5=      �� 5>      -   5         ��Name$ TitleBar��5>      $
 	10 10 0 0��6+   $��0��6D   ���#233C50 J� InputBindings 5?      d� 5@       d� Gesture$ 	LeftClicka�6'    �� Command# [ 6;   d� 5A      $ LeftDoubleClicka�6'   # [ 6B   ._�5C      � 	 5D      �� 5E      �� 5F      $	��100 �6/   .+�5H      �� $��motherboard.ico��6    $
��Left=�69   $��30��6T   $��20 0 q�6`   �� 5I       	 
TitleStyle#��[	 6;   ��6$   �� *Title+6;   � 5J      .+�5K      �� #��[	 6(   $��Right=�6L   $��20(�6h   $��24��6v   $��115 0q�6�   Help6�   �� 5L      $��question-mark.png��6$   $��Right=�6?   $��30��6[   $��80 0 q�6g   5M       � ToolTip 5N   "   � 5O   &   
������ .+�5P   *   ��  
 Background3#��[
 61   $��-9q�6V   $
 5��6b   ���	#FF102637._�5Q   .   ��   	Developer#���  68     SimpleTextStyle#��[ 6[   $��14(�6�   $��20q�6�   $
��Wrap=�6�   6�   5R   +   5S   '   5U      �� 5V      -   5         ��Name$ Localize��5V   #    �� SelectedIndex$ 1��65     MaterialDesignComboBox#��[ 6G   $��50��6w   $��40��6�   
�������$��Right=�6�   $��0 0 20 0q�6�   .
  (System.Windows.Interactivity.Interaction 
  Triggers 5W      /  )System.Windows.Interactivity.EventTrigger  5X   "      	EventName$ SelectionChanged��61   .  (System.Windows.Interactivity.TriggerBase   Actions. 5Y   &   6  0System.Windows.Interactivity.InvokeCommandAction     Command# [ 6�      CommandParameter 6<   ��   �� ElementName$  Localize��! �� Path$! SelectedItem�6�   5Z   #   .@�5\      �� -   5        $��ua��5\   +   $��30��65   .��5]   "   �� $��ua��6,   #��[ 66   5^      �� 5_      -   5        $��en��5_   +   $��30��65   .��5`   "   �� $��en��6,   #��[ 66   5a      5b      �� 5c      $��1��6!   #��[  61     ExitApp#��[ 6\   $��0 0 20 0q�6}   �� 5d      $��1��6!   #��[ 61     MinimizeWindowStyle#��[ 6b   $��0 0 20 0q�6�   5e      5f      � 5g      $��1��6   	 5h      �� 5i      $	��250 �6+   �� 5j      .+�5m      �� $��0��6   ���#14212A$
 0 0 0 10��6B   ._�5n      �  5o      �� 5p   "   �� 5q   "   $��90 �60   .+�5s      �� $ Vertical=�6*   $
��0 40q�6A   .+�5t   "   	� $��50��6.   #���  6:   
�������$��14(�6�     NavigateButton#��[ 6�   ��6e   �� *MotherboardCommand+6�   	� 5u   "   $��50��6.   #���  6;   
�������$��14(�6�   #��[ 6�   ��6^   �� *
CPUCommand+6�   	� 5v   "   $��50��6.   #���  6;   
�������$��14(�6�   #��[ 6�   ��6a   �� *MemoryCommand+6�   	� 5w   "   $��50��6.   #���  6:   
�������$��14(�6�   #��[ 6�   ��6]   �� *
GPUCommand+6�   5y      �� 5{      $��1��6(   $��System software 2023��65   $
��Wrap=�6Q   #��[ 6e   $��14(�6�   $��20q�6�   5|      5}      � 5~      $��1��6   .+�5      �� ��6)   �� *CurrentView+5�      5�      5�      5�      5�      5�      