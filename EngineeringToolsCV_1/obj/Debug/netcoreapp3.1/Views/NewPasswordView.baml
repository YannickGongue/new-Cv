   M S B A M L   `   `   `  ����O  KEngineeringToolsCV_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:EngineeringToolsCV_1.ViewsEngineeringToolsCV_1.Views  5   	   ;"clr-namespace:EngineeringToolsCV_1EngineeringToolsCV_1  5   	   ,    &EngineeringToolsCV_1.Views.NewPassword   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:EngineeringToolsCV_1.Views     5   	   7Controls"clr-namespace:EngineeringToolsCV_1     5   	     � Title$  New Password��5	   	   $	��265��5
   	   $	��570��5   	   $	��265��5   	   $	��570��5   	    � WindowStyle$
 None=�5   	   
������� � ShowActivated 5   	   ��  �� Path$ setActiveWindows� � 	Resources 5         
LabelStyle �� 
TargetType �� Property �� Value  TextBoxStyle  TextBlockStyle �� Triggers	 P� Property
 P� Value��%  &	        &	 �     &	 �    �� 5   
   " ��6#   .�5      ��  � ��$	 300��6&   �� 5       � ��$ 50��6'   �� 5       � ��$ 30(�6)   �� 5       � ��$
 Left=�64   �� 5       � ��$ Center=�62   5      �� 5   
   " ��6%   .�5      ��  � ��$	 250��6&   �� 5       � ��$ 30��6'   �� 5       � ��
 �����6,   �� 5       � ��$ 1q�60   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   5       �� 5!   
   " ��6'   .�5"      ��  � ��$ 20(�6)   �� 5#       � ��$	 200��6&   �� 5$       � ��$ 30��6'    5%      P� 5&      	 �@J�IsMouseOver$

 true��61   . �5'      ��  � ��$
 Bold"�63   5(      5*      5+      .��5,      �  � ColumnDefinitions 5-   
   �� 5.      $��* �6   �� 5/      $��* �6    � RowDefinitions 51   
   �� 52      $��50 �6   �� 53      $��50 �6   �� 54      $��50 �6   �� 55      $��50 �6   �� 56      $��50 �6   .+�58   
   �� $��Passwort resetzen��6   $	��120��6-   $��30��69   $��Center=�6E   $	��Top=�6b   $��
-150,0,0,0q�6z   $��15(�6�   .   (EngineeringToolsCV_1.Views.ucRoundButton  59   
   .   (EngineeringToolsCV_1.Views.ucRoundButton   Click$ CloseButton_Click��6�   $��1��6   $	��Top=�6.   $��Right=�6F   $��0,0,3,0q�6c      
Background
 �  ��$��30��6�   $��30��6�      CornerRadius$ 27��6�   6�     5:   
   $ MinimizeButton_Click��6�   $��1��6   $	��Top=�6/   $��Right=�6G   $��0,0,32,0q�6d   
 � ���$��30��6�   $��30��6�   $ 27��6�   6�     5;   
   $ MaximizeButton_Click��6�   $��1��6   $	��Top=�60   $��Right=�6H   $��0,0,60,0q�6e   
 � � �$��30��6�   $��30��6�   $ 27��6�   6�   �� 5<   
   #��[  6   $��0��64   $��1��6D   $��Benutzername* :��6Q   $��5,2,0,0q�6k   �� 5=   
   #��[  6   $��0��64   $��2��6D   $��Passwort* :��6Q   $��5,2,0,0q�6g   �� 5>   
   #��[  6   $��Password Confirm* :��64   $��3��6R   $��0��6_   $��5,2,0,0q�6p   $	��240��6�   $��50��6�   $��26(�6�   �� 5?   
   #��[ 6   $��1��69   $��3��6I   $	��250��6V   $��30��6b   $��18(�6n   �� 5@   
   -   5        $��Username��5@      $��1��6"   $��1��6/   #��[ 6?   �� 5A   
   -   5        $��Password��5A      $��2��6"   $��1��6/   #��[ 6?   %   EngineeringToolsCV_1.IconButton  5B   
   $��1��5C      $��4��5D        Cancel-Icon   PathData# [ 5E         CornerRadius$ 7��5F      $	��130��5G      $��42��5H         Text$ 	Abbrechen��5I      
����iA�
�������
�������$��1q�5M      $
��Left=�5N      $��1,0,0,0q�5O      $��18(�5P       � Cursor$
 Hand��5Q        5R   
   $��1��6   $��4��6.    
 Reload# [ 6;   $ 7��6_   $	��130��6p   $��42��6|   $ resetzen��6�   
����iA�
�������
�������$��1q�6�   $��Right=�6�   $��	10,0,10,0q�6	  $��18(�6  $
 Hand��6*  5S      5T      