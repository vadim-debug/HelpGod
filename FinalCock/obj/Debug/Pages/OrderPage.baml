   M S B A M L   `   `   `  ����D  @FinalCock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FinalCock.PagesFinalCock.Pages  5   	       FinalCock.Pages.OrderPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FinalCock.Pages     5   	     � Title$  	OrderPage��5   	   $	��450��6   $	��800��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��49* �6   �� 5      $	��99* �6   �� 5      $	��69* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DgProduct��5         
IsReadOnly .    AutoGenerateColumns .  $��0,98,0,0q�6T   $��3��6f      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6X     5      $ Producer��6%   $ * 6Z    67   �� *Producers.Name+6f     5      $
 Cost��6%   $ * 6L    63   �� *Cost+6X     5      $
 Sale��6%   $ * 6L    63   �� *Sale+6X     5      6'   	 � ContextMenu	 5      �� 5      .@�5      m� -   5        $��Удалить��5      6I   5      5      �� 5   
   $
��Left=�6   $��	18,15,0,0q�6/   $��2��6B   $
��Wrap=�6O   $��	TextBlock��6c   $	��Top=�6t   �� 5   
   $
��Left=�6   $��	18,36,0,0q�6/   $��2��6B   $
��Wrap=�6O   $��	TextBlock��6c   $	��Top=�6t   �� 5   
   $
��Left=�6   $��18,0,0,0q�6/   $��2��6A   $
��Wrap=�6N   $��	TextBlock��6b   $��Center=�6s   �� 5    
   $
��Left=�6   $��
18,106,0,0q�6/   $��2��6C   $
��Wrap=�6P   $��	TextBlock��6d   $	��Top=�6u   �� 5"   
   -   5        $��CmbPP��5"      $
��Left=�6    
 �� DisplayMemberPath$

 Name��6;   $��
601,35,0,0q�6T   $��2��6h   $	��Top=�6u   $	��120��6�   6�   �� 5$   
   -   5         ��Name$ txtCostOrder��5$      $
��Left=�6*   $��
104,24,0,0q�6E   $��2��6Y   $
��Wrap=�6f   $��	TextBlock��6z   $	��Top=�6�   �� 5%   
   -   5        $ txtSaleOrder��5%      $
��Left=�6*   $��
108,52,0,0q�6E   $��2��6Y   $
��Wrap=�6f   $��	TextBlock��6z   $	��Top=�6�   �� 5&   
   -   5        $ txtDateOrder��5&      $
��Left=�6*   $��
108,83,0,0q�6E   $��2��6Y   $
��Wrap=�6f   $��	TextBlock��6z   $	��Top=�6�   �� 5'   
   -   5        $ 
txtDateDel��5'      $
��Left=�6(   $��120,115,0,0q�6C   $��2��6X   $
��Wrap=�6e   $��	TextBlock��6y   $	��Top=�6�   �� 5(   
   -   5        $��BtnRegOrder��5(   *   $!��Оформить заказ��6   $
��Left=�6W   $��346,104,0,0q�6r   $��2��6�   $	��Top=�6�   5*      5+      