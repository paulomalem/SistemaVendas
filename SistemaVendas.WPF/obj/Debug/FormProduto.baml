   M S B A M L   `   `   `  ����L  HSistemaVendas.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SistemaVendas.WPFSistemaVendas.WPF  5   	   #    SistemaVendas.WPF.FormProduto   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SistemaVendas.WPF     5   	     � Title$  Produtos��5   	   $��326.019��6   $��569.768��6+    � WindowStartupLocation$ CenterScreen=�6;    � 
ResizeMode$ NoResize=�6`   .��5	      � .+�5
   
   �� -   5         ��Name$ btnProdutoNovo��5
      $
��Novo��6)   $
��Left=�68   $��	18,29,0,0q�6S   $	��Top=�6f   $��75��6~    J� RenderTransformOrigin$ 1.654,0.528&�6�   6�   �� 5   
   -   5        $ btnProdutoExcluir��5      $��Excluir��6,   $
��Left=�6>   $��
203,29,0,0q�6Y   $	��Top=�6m   $��75��6�   $ 1.654,0.528&�6�   6�   �� 5   
   -   5        $ 
btnAlterar��5      $��Alterar��6%   $
��Left=�67   $��
108,29,0,0q�6R   $	��Top=�6f   $��75��6~   $ 1.654,0.528&�6�   6�   �� 5   
   -   5         ��Name$ listaProduto��5      $ �� IsSynchronizedWithCurrentItem$
 TrueY�6)    �� SelectionMode$ Single=�6N   $
��Left=�6}   $	��216��6�   $��	10,63,0,0q�6�   $	��Top=�6�   $	��544��6�   
�������$��14(�6�   $��
2147483643��6�   ��6e   ��  �� View 5      �� 5      .P�5      �� $��Código��6%   	 �� Width$
	 80px��65   
 �� DisplayMemberBinding
 6B   �� *Id+�� 5      $��Produto��6%   $	 220px��66   
 6D   �� *	Descricao+�� 5      $��
Quantidade��6%   $	 100px��69   
 6G   �� *
Quantidade+�� 5      $��Valor��6%   $	 140px��64   
 6B   �� *Valor+5      5      5      5      