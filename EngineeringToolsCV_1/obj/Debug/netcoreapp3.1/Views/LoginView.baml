   M S B A M L   `   `   `  ����O  KEngineeringToolsCV_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:EngineeringToolsCV_1.ViewsEngineeringToolsCV_1.Views  5      ;"clr-namespace:EngineeringToolsCV_1EngineeringToolsCV_1  5      *    $EngineeringToolsCV_1.Views.LoginView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:EngineeringToolsCV_1.Views     5      7Controls"clr-namespace:EngineeringToolsCV_1     5      $	��310��5
      $	��550��6   
������   � 	Resources  5         
LabelStyle �� 
TargetType �� Property �� Value  TextBoxStyle  TextBlockStyle �� Triggers P� Property P� Value��%g  &	        &	 �     &	 G    �� 5   
   " ��6#   .�5      ��  � ��$	 300��6&   �� 5       � ��$ 50��6'   �� 5       � ��$ 30(�6)   5      �� 5   
   " ��6%   .�5      ��  � ��$	 250��6&   �� 5       � ��$ 30��6'   �� 5       � ��
 �����6,   �� 5       � ��$ 1q�60   5      �� 5   
   " ��6'   .�5      ��  � ��$ 20(�6)   �� 5       � ��$	 200��6&   �� 5       � ��$ 30��6'    5      P� 5       �@J�IsMouseOver$
 true��61   . �5      ��  � ��$
 Bold"�63   5      5!      5"      .��5#      �� 
�������$��1q�5$       �� CornerRadius$ 15��5%      
�������._�5'   
   � .+�5(      ��   LabelBenutzernameAngeben#��[ 5)      $	��400��5*      $��30��6   $
��Left=�5+      $	��Top=�5,      $��10,2,0,0q�5-      $��20(�5.      �� 5/      
����iA�$��2��51      $	��Top=�6   $��	5,35,10,0q�52      �� 53      #��[  54        LabelBenutzername#��[ 55      $	��230��56      $
��Left=�57      $	��Top=�58      $��	20,50,0,0q�59      �� 5:      #��[  5;        LabelPasswort#��[ 5<      $��
20,120,0,0q�5=      $	��195��5>      $
��Left=�5?      $	��Top=�5@      	� 5A      -   5        $��ShowPassword��5B      $	��300��5D      $��25��5E      $��20(�5F      $��
145,60,0,0q�5G      $��Center=�5H      $��Center=�5I        LabelPasswordAnzeigen#��[ 5J       d� 	IsChecked 5C      �� 	 �� Path$	 PasswordChecked�5J      �� 5L      -   5        $��strUsername��5M      #��[ 5O      $��Right=�5P      $	��Top=�5Q      $��	0,55,20,0q�5R      ��5N      �� $	 Username�5R      �� 5T      -   5        $��strPassword��5U      #��[ 5V      $��Right=�5X      $	��Top=�5Y      $��
0,120,20,0q�5Z      $��18(�5[      ��5W      �� $	 Password�5[      %   EngineeringToolsCV_1.IconButton  5\      $��4��5]      
   CornerRadius$
 15��5^      $	��130��5_      
�������$��2q�5a      $��40��5b        ButtonAbbrechen   Text# [ 5c        Cancel-Icon   PathData# [ 5d      
����iA�
�������$
��Left=�5g      $��250,160,0,5q�5h      $��18(�5i       � Cursor$
 Hand��5j      $��2��5k      ��5l      �� *NavigateCancelCommand+  5n      $��4��5p      $
 15��5q      $	��130��5r      
�������$��2q�5t      $��40��5u       	 ButtonAnmelden# [	 5v       
 
Login-Icon# [
 5w      
����iA�
�������$��Right=�5z      $��
0,160,15,5q�5{      $��18(�5|      $
 Hand��5}      $��1��5~      ��5o      �� *NavigateLoginCommand+5~      �� 5      $��0��5�      $��5��5�      #��[ 5�      $��0,240,25,20q�5�      $��Right=�5�      $��Bottom=�5�      �� 5�      -   5         �Name$ hyperlinkButton��5�      
����iA� �� Command 5�      �� $	 UserResetCommand� �� 	IsEnabled 5�      �� $	 UserResetEnabled�.�6F   Password vergessen5�      5�      �� 5�      #��[ 5�      $��	50,0,0,20q�5�      $
��Left=�5�      $��Bottom=�5�      {�5�      �� $	 SetActivedWindow��� 5�      
����iA� 5�      �� $	 RegisterCommand�.�6;   User registrieren5�      5�      5�      5�      5�      