   M S B A M L   `   `   `  ���� N  JInactivityPreventer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MouseMove	MouseMove      MouseMove.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:MouseMove       � Title$  Inactivity Preventer��$	��600��$	��550�� � 
ResizeMode$ NoResize=�.���  � RowDefinitions �� $��* ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � � 	Resources  �� 
TargetType �� Property �� Value��%�  '��       '�� ~     '�� �     '�� <    '�� �    �� " ��.���  � ��$ 30����  � ��$	 150����  � ��$ 15(���  � ��$
 Bold"���  � ��$ 10q��� " ��.���  � ��$ Center=���  �@��Orientation$ 
Horizontal=��� " ��.���  � ��$
 10,5q���  � ��$
 Left=���  � ��$ Center=���  � ��$ 15(��� " ��.���  � ��$ Center=���  � ��$
 Left=���  � ��$ 20(���  � ��$
 2,10q��� " ��.���  � ��$ Center=���  � ��$ Center=���  � ��$ 30����  � ��$ 15(���  � ��$ Center=���  � ��$ Right=���  � ��$ 40����  � ��$ 2,5,2,5q�.+��� -    ��Name$ 
MouseImage��$��.\mouse.png��$��0,10,0,0q�$��0�� K� ZIndex$ 1��	 J� Opacity$		 0.3Q��� -   
 ��Name$
 
AboutLabel��$��?��$��0��$	��Top=�$��Right=�$��15(�$��30��$��Center=�$��0,0,5,0q�$ 11��� -    �Name$ 	AboutGrid��$��0��$ 5��$��0,10,0,0q�$��Center=�$��Center=� �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $��* ��� $��* �    AboutHeader  AboutContent��%k  &	        &	 �     �� " ��.���  � ��$ 15(���  � ��$
 Bold"���  � ��$ Right=���  � ��$ Center=���  � ��$
 5,10q��� " ��.���  � ��$ 15(���  � ��$
 Left=���  � ��$ Center=���  � ��$
 5,10q���  � ��
 ���� ��  � ��$ 0q���  � ��
 ���� ��  �@��
IsReadOnly . .+��� $��Version:��#��[  $��1��$��0���� $	��1.0��#��[ $��1��$��1���� $��Code:��#��[  $��2��$��0����  �� Orientation$ Vertical=�$��2��$��1��$
��Left=�.+��� $��Kacper Stachowski��$��5,5,5,1q�#��[ �� $��kacper_st@op.pl��$��5,1,5,5q�#��[ �� $��Mouse image:��#��[  $��3��$��0���� $ Vertical=�$
��Left=�$��3��$��1��.+��� $��Kaja Kosmala��#��[ $��5,5,5,1q��� $��nemezis1314@gmail.com��$��5,1,5,5q�#��[ �� -    ��Name$ TimerStackPanel��$��1��.+��� $��Time passed:��$��20(�$
��Bold"�$��
10,10,0,10q��� -    ��Name$ TimerLabelHours��$��00���� $��:���� -   $ TimerLabelMinutes��$��00���� $��:���� -   $ TimerLabelSeconds��$��00���� -    ��Name$ OptionsGroupBox��$��Options��$
��10,5q�$��2��.���� .+��� $��0,0,10,0q�.+��� $��Actions per loop:�� � ToolTip$� �Set how many actions will be performed per loop. The number of actions will be selected randomly for every loop, by given range.��$��0,0,2,0q��� -	    ��Name$$ NumberOfActionsMinValueTextBox��$��10�� �� 	MaxLength$ 2��$� �Set how many actions will be performed per loop. The number of actions will be selected randomly for every loop, by given range. Minimum value is 10 and maximum is 98.���� $��-��$��2,0,2,0q��� -
   $$ NumberOfActionsMaxValueTextBox��$��30��$ 2��$� �Set how many actions will be performed per loop. The number of actions will be selected randomly for every loop, by given range. Minimum value is 11 and maximum is 99.���� $��10,0,0,0q�.+��� $��Interval [s]:��$��0,0,2,0q�$4 .Set how much time has to pass between actions.���� -   $ IntervalTextBox��$��30��$��2,0,0,0q�$4 .Set how much time has to pass between actions.���� -   $ KeyboardGroupbox��$
��10,5q�$��3������ -    ��Name$ IsKeyboardIncluded��$��Center=����� $*��$Use keyboard while performing action��$��12(�$��2,0,0,0q�.���� -   $ KeyboardOptionsStackPanel��.+��� $��Text written per action:��$Q KSet what will be written in each action. You can input up to 10 characters.��$��0,0,2,0q��� -   $ KeyboardInputTextBox��$��Q��$
��Left=�$ 10��$	��100��$Q KSet what will be written in each action. You can input up to 10 characters.���� $��4��.+��� -    ��Name$ StartButton��$
��Bold"�$��Start���� -   $ 
StopButton��$
��Stop��� -    �Name$ TimeProgressBar��$��5��$��10��