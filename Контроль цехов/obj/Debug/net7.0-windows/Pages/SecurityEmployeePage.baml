   M S B A M L   `   `   `  ����V  RКонтроль цехов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:УППО_Пропуски.PagesУППО_Пропуски.Pages  5      :    4УППО_Пропуски.Pages.SecurityEmployeePage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:УППО_Пропуски.Pages     5      -   5        $	��450��5      $	��800��6A     N� Title$  SecurityEmployeePage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��0.05* �6   �� 5      �� 5      $��0.05* �6    � RowDefinitions 5   
   �� 5      $��0.05* �6   �� 5      �� 5      $��0.05* �6   .+�5   
   � $��1��6   $��1��6   .+�5      �� .@�5      ��    MainTabItem#���   6   ��5      �� 5       � ToolTip$  В виде таблицы��6    $+��%../Assets/Button Icons/table-icon.png��69   $��40��6h   .��5      �  5      �� 5   "   �� 5   "   $
��auto �63   .+�5!      � $��0��6#   .+�5"      &   System.Windows.Controls.DataGrid  -   5          Name$ EmployeesDataGrid��5"   '      AutoGenerateColumns$ False��6B    �� AlternationCount$ 1��6^   ���	#FFD3D9FF   AlternatingRowBackground �	#FFECEFFF   GridLinesVisibility$ 
Horizontal=�6�   	   HorizontalGridLinesBrush	 �	#FF80ABFF
   CanUserAddRows$
 False��6�      CanUserDeleteRows$ False��6     CanUserResizeRows$ False��6&     Columns 5#   &   0  *System.Windows.Controls.DataGridTextColumn  5$   *   ,  &System.Windows.Controls.DataGridColumn   Header$ Код��6=      FontSize$ 20Q�6J      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6e   ��  �� Path$
 Code�  5%   *   $ Фамилия��6=   $ 20Q�6N   $
 auto 6\    6i   �� $ Surname�  5&   *   $ Имя��6=   $ 20Q�6J   $
 auto 6X    6e   �� $
 Name�  5'   *   $ Отчество��6=   $ 20Q�6O   $
 auto 6]    6j   �� $ 
Patronomic�  5(   *   $ Цех��6=   $ 20Q�6J   $
 auto 6X    6e   �� $ DivisionName�  5)   *   $  Подразделение��6=   $ 20Q�6T   $
 auto 6b    6o   �� $ WorkshopName�  5*   *   $ Статус��6=   $ 20Q�6M   $
 auto 6[    6h   �� $ Status�  5+   &   $1 +Проходить в другие цеха��69   $ 20Q�6Z   $
 auto 6h    6u   �� $" StringCanVisitOtherWorkshops�5-   #   5.      � 5/      $��1��6   ���	#FFE7EEFD 50   "   �� 51   &   $
��auto �67   �� 52   &   $	��200��67    54   "   �� 55   &   �� 56   &   �� 57   &   �� 58   &   �� 59   &   $
��auto �64   .+�5;      �� 
����  �$��1q�6<   $��10��6P   $��10��6e   �� 5=      $=��7Может проходить в другие цеха?��6(   $	��200��6N   �� 5>   "   -   5         ��Name$ CanVisitOtherWorkshops��5>   +   $��1��6K   $��Center=�6[   $��Center=�6v   $��5q�6�    � LayoutTransform 5?   &   �� 5@   *    �� ScaleX$ 2Q�69    �� ScaleY$ 2Q�6D   5B   #   �� 5D      $��Пароль: ��6(   $��1��68   �� 5E      -   5         ��Name$ PasswordEmployeeTextBox��5E   O     MainTextBox#���  6&    �� 	MaxLength$ 45��6p   $��1��6   $��1��6�   �� 5G      $"��Подразделение: ��6(   $��2��6?   �� 5H      -   5         ��Name$ DivisionEmployeeComboBox��5H   U     ComboBoxTemplate#���  6'   ���	#FFE9F7FF$��1��6�   $��2��6�   ��5I   "   �� 5J   &   .R�5K   *   �� ��64   �� $
 Name�5L   '   5N      �� 5P      $��Статус: ��6(   $��3��68   �� 5Q      -   5        $ StatusEmployeeTextBox��5Q   O   #���  6&   $ 45��6n   $��3��6}   $��1��6�   � 5S      $��4��6#   $��2��60    5T   "   �� 5U   &   �� 5V   &   .+�5X   "   �� -   5         ��Name$ SaveChangesButton��5X   N     
MainButton#���  6)   $) #Одобрить/Сохранить��6i   .��5Y   &   �� $,��&../Assets/Button Icons/AddEmployee.png��6,   $��50��6\   5Z   #   �� 5[   "   -   5        $ CancelChangesButton��5[   N   #���  6)   $ Отменить��6k   $��1��6�   .��5\   &   �� $.��(../Assets/Button Icons/cancel-button.png��6,   $��50��6^   5]   #   5^      5_      5`      5a      �� 5b      #���   6   ��5c      �� 5d      $ В виде списка��6    $*��$../Assets/Button Icons/list-icon.png��68   $��40��6f   .��5f      �� -	   5         ��Name$ EmployeesListBox��5f      
����  �$��Stretch=�6O   5g      �� 5h      #���   6   ��5i      �� 5j      $ Логи системы��6    $*��$../Assets/Button Icons/logs-icon.png��67   $��40��6e   .��5l        -
   5        $ LogsDataGrid��5l      $ False��65   $ 1��6Q   ���	#FFD3D9FF �	#FFECEFFF$ 
Horizontal=�6�   	 �	#FF80ABFF$
 False��6�   $ False��6�   $ False��6   5m        5n      $ 
Время��61   $ 20Q�6@   $
 auto 6N    6[   �� $ Datetime�  5o      $ Действие��61   $ 20Q�6C   $
 auto 6Q    6^   �� $ Action�5q      5r      5s      �� 5u      -   5        $ SearchTextBox��5u   ?   #���  6   $��0��6V   $	��Top=�6c   $��175,10,50,0q�6{   6�   �� 5v      -   5         ��Name$ SearchTextBlock��5v      $M��GВведите текст чтобы найти сотрудника...��61   $	��Top=�6`   $
��Left=�6x   $��200,10,50,0q�6�   ���	#FFE9F7FF6�   �� 5x      -   5        $ 
QuitButton��5x   �   #���  6   
���  �����	#FFFF8787$��Right=�6c   $	��Top=�6   $��0q�6�   $$ Выйти из системы��6�   .��5y      �� $%��../Assets/Button Icons/exit.png��6   $��5q�6A   $��30��6L   5z      5{      5|      5}      