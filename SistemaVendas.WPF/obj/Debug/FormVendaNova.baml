   M S B A M L   `   `   `  ����L  HSistemaVendas.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SistemaVendas.WPFSistemaVendas.WPF  5   	   %    SistemaVendas.WPF.FormVendaNova   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SistemaVendas.WPF     5   	     � Title$  
Nova Venda��5   	   $��523.019��6   $��658.302��6-    � WindowStartupLocation$ CenterScreen=�6=    � 
ResizeMode$ NoResize=�6b   .��5	      � .+�5
   
   �� -   5         ��Name$ 
lblCliente��5
      $
��Left=�6(   $��	10,29,0,0q�6C   $
��Wrap=�6V   $��Cliente:��6j   $	��Top=�6z    �� TextAlignment$ Right=�6�   $��65��6�   �� 5   
   -   5         ��Name$ comboCliente��5      $
��Left=�6�   $��	80,29,0,0q�6�   $	��Top=�6�   $	��139��6�   {�. ��6)   �� *ListaCliente+��5      �� 5      .R�5      �� ��6    �� *Nome+5      5      �� 5   
   -   5         ��Name$ btnNovaVenda��5      $��
Nova Venda��6'   $
��Left=�6<   $��
253,26,0,0q�6W   $	��Top=�6k   $	��112��6�   $��29��6�   6�   �� 5   
   -   5         ��Name$ textCodigoVenda��5      {�.  $
��Left=�6>   $��23��6Y   $��554,196,0,0q�6e    �� TextWrapping$
 Wrap=�6z   $	��Top=�6�   $��75��6�   $y�Hidden=�6�   �� 5   
   -   5        $ textQuantidade��5      $
��Left=�6*   $��23��6E   $��
80,113,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $��71��6�   $y�Hidden=�6�   �� 5   
   -   5        $ 	textValor��5      {�.  $
��Left=�67   $��23��6R   $��200,114,0,0q�6^   $
 Wrap=�6s   $	��Top=�6�   $��82��6�   $y�Hidden=�6�   �� 5   
   -   5        $ 
lblCdVenda��5      $
��Left=�6(   $��431,197,0,0q�6C   $
��Wrap=�6X   $��Código da Venda :��6l   $	��Top=�6�   $ Right=�6�   $	��118��6�   $��22��6�   $y�Hidden=�6�   �� 5   
   -   5        $ 
lblProduto��5      $
��Left=�6(   $��	10,86,0,0q�6C   $
��Wrap=�6V   $��Produto:��6j   $	��Top=�6z   $ Right=�6�   $��65��6�   $��22��6�   $y�Hidden=�6�   �� 5   
   -	   5        $ lblQuantidade��5      $
��Left=�6+   $��
10,114,0,0q�6F   $
��Wrap=�6Z   $��Quantidade:��6n   $	��Top=�6�   $ Right=�6�   $y�Hidden=�6�   �� 5   
   -
   5        $ lblValor��5      $
��Left=�6&   $��156,114,0,0q�6A   $
��Wrap=�6V   $��Valor:��6j   $	��Top=�6x   $ Right=�6�   $��39��6�   $y�Hidden=�6�   �� 5   
   -   5        $ comboProduto��5      $
��Left=�6x   $��	80,86,0,0q�6�   $	��Top=�6�   $	��202��6�   $y�Hidden=�6�   ��5      �� 5      .R�5      �� ��6    �� *	Descricao+5      5!      �� 5#   
   -   5        $ btnNovoProduto��5#      $��Novo Produto��6)   $
��Left=�6@   $��
80,142,0,0q�6[   $	��Top=�6o   $	��202��6�   $��27��6�   $y�Hidden=�6�   �� 5$   
   -   5        	 ��Name$	 listaProdutoVenda��5$      
 �� SelectionMode$
 Single=�6.   $
��Left=�6]   $	��216��6x   $��10,224,0,-9q�6�   $	��Top=�6�   $	��623��6�   
�������$��14(�6�   $��
2147483643��6�   $y�Hidden=�6�   ��6E   ��  �� View 5%      �� 5&      .P�5'      �� $��Código��6%    �� Width$
 80px��65    �� DisplayMemberBinding 6B   �� *Id+�� 5(      $��Produto��6%   $ 300px��66    6D   �� *	Descricao+�� 5)      $��
Quantidade��6%   $ 100px��69    6G   �� *
Quantidade+�� 5*      $��Valor Unitário��6%   $ 140px��6=    6K   �� *Valor+5+      5-      �� 5.   
   -   5        $ lblValorTotal��5.      $
��Left=�6+   $��134,453,0,0q�6F   $
��Wrap=�6[   $	��Top=�6o   $��66��6�   $��23��6�   $y�Hidden=�6�   �� 6�   $�Valor Total��6�   �� 6�   $�:��6�   �� 6�   �� 6�   6�   �� 5/   
   -   5        $ textValorTotal��5/      {�.  $
��Left=�6<   $��23��6W   $��200,451,0,0q�6c   $
 Wrap=�6x   $	��Top=�6�   $	��120��6�    J� RenderTransformOrigin$ 0.267,-0.087&�6�   $y�Hidden=�6�   �� 50   
   -   5        $ btnFinalizarVenda��50      $��Finalizar Venda��6,   $
��Left=�6F   $��
10,450,0,0q�6a   $	��Top=�6u   $	��103��6�   $��23��6�   $y�Hidden=�6�   51      52      