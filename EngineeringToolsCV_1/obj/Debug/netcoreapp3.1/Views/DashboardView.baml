   M S B A M L   `   `   `  ����O  KEngineeringToolsCV_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:EngineeringToolsCV_1.ViewsEngineeringToolsCV_1.Views  5   	   ;"clr-namespace:EngineeringToolsCV_1EngineeringToolsCV_1  5   	   .    (EngineeringToolsCV_1.Views.DashboardView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :views(clr-namespace:EngineeringToolsCV_1.Views     5   	   7controls"clr-namespace:EngineeringToolsCV_1     5   	   $	��650��5
   	   $	��800��6   
������ .��5      � $	��650��6   $	��800��6   .+�5   
   %   EngineeringToolsCV_1.IconButton  $	��180��5          Text$  Information��5         Information   PathData# [  5      $	��255��5      $
��Left=�5      $	��Top=�5       � Cursor$
 Hand��5      
�������$��2q�5      $��5,25,0,0q�5         CornerRadius$ 15��5         Orientation$ Vertical=�5      $��20(�5      $��Information��5!      {�5      ��  �� Path$ SetEnableInfo���5      �� *InfoBackColor+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ Default=���5      �� *InfoForeGroundColor+$ TwoWay=�$ Default=���5       �� *InfoCommand+5!        5"   
     LabelBerufserfahrung#  [ 5#      $ 15��5$        	file-info# [ 5%      $	��255��5&      $	��180��5'      $��
270,25,0,0q�5+      $
 Hand��5,      $	��Top=�5-      $
��Left=�5.      $ Vertical=�5/      
�������$��2q�51      $��20(�52      $��Beruf��54      {�5(      �� $ SetEnableBeruf���5)      �� *BerufBackColor+$ TwoWay=�$ Default=���5*      �� *BerufForeGroundColor+$ TwoWay=�$ Default=���53      �� *BerufCommand+54        55   
   %   EngineeringToolsCV_1.IconButton   Click$ ProjektToggleButton_Click��5@        LabelProjekt#  [ 56      $ 15��57        Bookmark# [ 58      $	��255��5:      $	��180��5;      $��325,25,10,0q�5?      $
 Hand��5A      $	��Top=�5B      $��Right=�5C      
�������$��2q�5E      $ Vertical=�5F      $��20(�5G      ��59      �� *ProjektCommand+{�5<      �� $ SetEnableProject���5=      �� *ProjektForeColor+��5>      �� *ProjektBackColor+$ TwoWay=�$ Default=�5G        5H   
   $" AusbildungToggleButton_Click��5S        LabelAusbildung#  [ 5I      $ 15��5J        
Ausbildung# [ 5K      $	��255��5L      $	��180��5M      $��0,235,10,10q�5R      $
 Hand��5T      $	��Top=�5U      $��Right=�5V      $ Vertical=�5W      
�������$��2q�5Y      $��20(�5Z      {�5N      �� $ SetEnableBildung���5O      �� *AusbildungForeColor+��5P      �� *AusbildungBackColor+$ TwoWay=�$ Default=���5Q      �� *FormationCommand+5Z        5[   
   $% QualifikationToggleButton_Click��5e   !     LabelQualifikation#  [ 5\      $ 15��5]        Qualifikation# [ 5^      $	��255��5`      $	��180��5a      $��5,0,0,0q�5e      $
 Hand��6I   $��Center=�6W   $
��Left=�6r   
�������$��2q�6�   $ Vertical=�6�   $��20(�6�   ��5_      �� *QualifCommand+{�5b      �� $ SetEnableQualication���5c      �� *QualifikationForeColor+��5d      �� *QualifikationBackColor+$ TwoWay=�$ Default=�5e   �     5f   
   $ MediaToggleButton_Click��5p        	 LabelSozialeMedien#  [	 5g      $ 15��5h       
 linkeln# [
 5i      $	��255��5j      $	��180��5k      $��	270,0,0,0q�5p      $
 Hand��5q      $��Center=�5r      $
��Left=�5s      $ Vertical=�5t      $��20(�5u      
�������$��2q�5w      ��5l      �� *MediaCommand+{�5m      �� $ SetEnableMedia���5n      �� *MediaForeColor+��5o      �� *MediaBackColor+$ TwoWay=�$ Default=�5w        5x   
   $" TätigkeitToggleButton_Click��5�        LabelTätigkeiten#  [ 5y      $ 15��5z      $	��255��5{      $	��180��5|        
Tätigkeit# [ 5~      $��270,420,0,0q�5�      $
 Hand��5�      $��Center=�5�      $
��Left=�5�      
�������$��2q�5�      $ Vertical=�5�      $��20(�5�      ��5}      �� *ActivitiesCommand+{�5      �� $ SetEnableActivität���5�      �� *TätigkeitForeColor+��5�      �� *TätigkeitBackColor+$ TwoWay=�$ Default=�5�        5�   
   $ HobbyToggleButton_Click��5�        LabelInteressen#  [ 5�      $ 15��5�        color-pallete# [ 5�      $	��255��5�      $	��180��6   $��
0,420,10,0q�5�      $
 Hand��5�      $��Center=�5�      $��Right=�5�      
�������$��2q�5�      $��20(�5�      $ Vertical=�5�      ��5�      �� *InterestCommand+{�5�      �� $ SetEnableHobby���5�      �� *InteresseForeColor+��5�      �� *InteresseBackColor+$ TwoWay=�$ Default=�5�        5�   
   $ ConfigToggleButton_Click��5�        LabelKonfigurationen#  [ 5�      $ 15��5�      $	��255��5�      $	��180��5�        Maintenance# [ 5�      $��	5,420,0,0q�5�      $
 Hand��5�      $��Center=�5�      $
��Left=�5�      $ Vertical=�5�      $��20(�5�      
�������$��2q�5�      ��5�      �� *ConfigCommand+{�5�      �� $ SetEnableConfig���5�      �� *ConfigForeColor+��5�      �� *ConfigBackColor+$ TwoWay=�$ Default=�5�      5�      5�      