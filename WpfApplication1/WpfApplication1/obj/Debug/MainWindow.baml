   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	   -   5          �Name$  
mainWindow��5	   	    � WindowStyle$
 None=�5   	    � Title$ 
MainWindow��5
   	   $	��240��6   $	��520��6)   $��Center=�65   $��Center=�6R   $��Center=�6m   $��Center=�6�    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�6.    � 	Resources 5         btv  	VsMenuTop �� 
TargetType m� IsSubmenuOpen � AllowsTransparency	 J� Opacity
 K� IsItemsHost �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value  	VsMenuSub ]�Name �� RelativeSource �� 	Converter �� Triggers �� 
TargetName  	VsMenuSep  VsOnline �� Orientation��%P	  &	        &	      &	 k    7   &	 �    &	 �    'o� n    �� 5   
   6'   �� 5   
   " m�6,   .R�5      �� $
��12px(�6   $��Medium"�63   $��25��6Q   $��90��6]   .+�5      �� #��z��6   $��0,0,0,0q�6;   
�������$��Center=�6_   $��Center=�6|   $��26��6�   � 5      #��z 6    . |�.  .��5      �� $��1q�6   ���#020202���#020202$
	 0.80Q�6]   ._�5      �� 
 . 6%   5      5      ��5      �� 5       " ��6    5!      P� 5"       �@J�IsMouseOver . . �5#   "   ��  � �� �#0202026?   �� 5$   "    �@�Cursor$ pressRag.cur��6;   5%      5'      5)      5*      �� 5.   
   " m�6,   .R�50      ]� $ panel��62   $
��10px(�6   .+�53      �� $��20��6a   $	��5,0q�6l   ��6   �� *Icon+ �� *TemplatedParent+6l   �� 54      #��z��6   
�������$	 60Q�6N   $��0,5,5,5q�6[   �� 57      y�6   �� *
HasItems+8    �� *TemplatedParent+� 5:      #��z 6    . |�.  $��Right=�6m   .��5;      �� $��1q�6   ���#020202���#020202$
	 0.25Q�6\   ._�5<      �� 
 . $
	 0.25Q�68   5=      5?      5A       5C      P� 5E       �@m�IsHighlighted . . �5F      �� $ panel��63    � �� �#EFF6FC6F   5G      P� 5H       �@J�IsMouseOver . . �5I      ��  � �� �#02020263   �� 5J       �@�Cursor$ pressRag.cur��6/   5K      5N      �� 5Q   
   " ��6,   .R�5R      �� $��1��6   ���#E0E0E06    5S      �� 5V   
   " m�6+   .R�5W      �� $
��12px(�6   $��Medium"�63   $��25��6Q   $��18��6]   $ 
Horizontal=�6h   ���#081015.+�5X      �� #��z��6   $��0,0,0,0q�6;   
�������$��Center=�6_   $��Center=�6|   �� 5Y      $��20��6   $��0,0,0,0q�6$   � 5\      #��z 6    . |�.  .��5]      �� $��1q�6   
����������#E0E0E0._�5^      �� 
 . 6%   5_      5`      ��5a      �� 5b      " ��6    5c      P� 5d       �@J�IsMouseOver . . �5e   "   ��  � �� �#0202026?   �� 5f   "    �@�Cursor$ pressRag.cur��6;   5g      5i      5k      5m      �� 5p   
   " o�6   .�5q      ��  � �� �#0202026+   �� 5r       � ��$
 25px��6'   �� 5s       �@J�Opacity$
 0.65Q�6(   5u      5w      .��5z      � .+�5|   
   r� -   5         r�Name$ mePlayer��5|       r� LoadedBehavior$
 Play=�6)    r� Source$ .\bin\Release\t.mp4?�6?   �� 5}   
   -   5         � Minimum$ 0Q�5}       � Maximum$	 100Q�6   $y�Hidden=�6+    � Value$ 50Q�6[   �� 5   
   -   5         ��Name$ image1��5   '   $��450,194,10,9q�6   $��.\skipBtn.png��5�      5�      �� 5�   
   -   5         ��Name$ checkBox��5�      $��Desativar Som��6%   
�������$
��Left=�5�      $��344,206,0,0q�6.   $	��Top=�6C   $��Trebuchet MS)�5�   M   $
��Bold"�6g   5�   S   �� 5�   
   .+�5�      o�  o� 
IsMainMenu . $	��Top=�6%   $��Right=�6=   .@�5�      m� $��_MENU��6   #��[ 6+   .@�5�      m� -   5        $��_YouTube��5�      #��[ 6O     m� Icon$  youTube.png��6u   m� 5�      -   5        $��_Discord��5�      #��[ 6O   $  discord.png��6u   5�      m� 5�      $��_X��6   #��[ 6'   5�      5�      5�      5�      5�      