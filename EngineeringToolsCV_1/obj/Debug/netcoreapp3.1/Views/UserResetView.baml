   M S B A M L   `   `   `  ����O  KEngineeringToolsCV_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:EngineeringToolsCV_1.ViewsEngineeringToolsCV_1.Views  5   	   ;"clr-namespace:EngineeringToolsCV_1EngineeringToolsCV_1  5   	   .    (EngineeringToolsCV_1.Views.UserResetView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:EngineeringToolsCV_1.Views     5   	   7Controls"clr-namespace:EngineeringToolsCV_1     5   	   $	��250��5	   	   $	��570��5
   	   $	��265��5   	   $	��570��5   	     � WindowStyle$
  None=�5   	   
������� � 	Resources 5         
LabelStyle �� 
TargetType �� Property �� Value  TextBoxStyle  TextBlockStyle �� Triggers P� Property P� Value��%&  &	        &	 �     &	     �� 5   
   " ��6#   .�5      ��  � ��$	 360��6&   �� 5       � ��$ 50��6'   �� 5       � ��$ 30(�6)   �� 5       � ��$
 Left=�64   �� 5       � ��$	 Top=�62   5      �� 5   
   " ��6%   .�5      ��  � ��$	 520��6&   �� 5       � ��$ 40��6'   �� 5       � ��$ 18(�6)   �� 5       � ��
 �����6,   �� 5       � ��$ 1q�60   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   5      �� 5    
   " ��6'   .�5!      ��  � ��$ 20(�6)   �� 5"       � ��$	 400��6&   �� 5#       � ��$ 30��6'    5$      P� 5%       �@J�IsMouseOver$
 true��61   . �5&      ��  � ��$
 Bold"�63   5'      5)      5*      .��5,      � .+�5-   
   �  � ColumnDefinitions 5.      �� 5/      $��* �6#   �� 50      $��* �6#   	 � RowDefinitions	 52      �� 53      $��50 �6    .+�55      �� $��Passwort resetzen��56      $	��120��57      $��30��58      $��Center=�59      $	��Top=�5:      $��
-150,0,0,0q�5;      $��15(�5<      .   (EngineeringToolsCV_1.Views.ucRoundButton  5=      .   (EngineeringToolsCV_1.Views.ucRoundButton
   Click$
 CloseButton_Click��5F      $��1��5>      $	��Top=�5?      $��Right=�5@      $��0,0,3,0q�5A         
Background
 �  ��$��30��5C      $��30��5D         CornerRadius$ 27��5E      5F        5G      $
 MinimizeButton_Click��5P      $��1��5H      $	��Top=�5I      $��Right=�5J      $��0,0,32,0q�5K      
 � ���$��30��5M      $��30��5N      $ 27��5O      5P        5Q      $
 MaximizeButton_Click��5Z      $��1��5R      $	��Top=�5S      $��Right=�5T      $��0,0,60,0q�5U      
 � � �$��30��5W      $��30��5X      $ 27��5Y      5Z      5[      � 5]   
   $��0,38,0,0q�6   	 5^      �� 5_      $��50 �6    �� 5`      $��70 �6    �� 5a      $��50 �6    .+�5c      �� $��0��5d      
����iA�$��2��5f      $	��Top=�6   $��5,0,10,0q�5g      �� 5h      #��[  5i      $��Email Adresse eingeben*:��5j      $��22,0,0,0q�5k      �� 5l      -   5        $��Username��5m      $��1��5n      #��[ 5o      ��5p      ��  �� Path$ SetEmail�%   EngineeringToolsCV_1.IconButton  5q      $��2��5r       
 Reload   PathData# [ 5s         CornerRadius$ 7��5t      $	��130��5u      $��42��5v        ButtonSuchen   Text# [ 5w      
���   �
�������$��1q�5{      $
��Left=�5|      $��410,-40,10,-60q�5}      $��18(�5~       � Cursor$
 Hand��5      $��2��5�      ��5x      �� *SetBackground+��5�      �� $ OnSearchCommand�{�5�      �� $ SetIsEnabled�5�      5�      5�      