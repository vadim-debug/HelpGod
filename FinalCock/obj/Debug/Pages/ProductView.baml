   M S B A M L   `   `   `  ����D  @FinalCock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FinalCock.PagesFinalCock.Pages  5      !    FinalCock.Pages.ProductView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:FinalCock.Pages     5      -   5          N� Title$  ProductView��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��7* �6   �� 5      $	��11* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DgProduct��5         
IsReadOnly .    AutoGenerateColumns .  $��1��6T      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 63   �� *Name+6X     5      $ Producer��6%   $ * 6Z   	 67   �� *Producers.Name+6f     5      $
 Cost��6%   $ * 6L   	 63   �� *Cost+6X     5      $
 Sale��6%   $ * 6L   	 63   �� *Sale+6X     5      6'   
 � ContextMenu
 5      �� 5      .@�5      m� -   5        $&�� Добавить к заказу��5      6S   5      5      �� 5   
   $
��Left=�6   $��
354,30,0,0q�6/   $
��Wrap=�6C   $!��Окно просмотра��6W   $	��Top=�6m   �� 5   
   -   5        $��	TxtSearch��5      $�� ��6   $
��Left=�6O   $��
27,131,0,0q�6j    �� TextWrapping$
 Wrap=�6~   $	��Top=�6�   $	��120��6�   �� 5    
   -   5         ��Name$ 
BtnToOrder��5    !   $��
Заказ��6   $
��Left=�6N   $��307,147,0,0q�6i   $	��Top=�6~   �� 5!   
   -   5        $��BtnBack��5!   !   $��
Назад��6   $
��Left=�6F   $��726,141,0,0q�6a   $	��Top=�6v   5"      5#      