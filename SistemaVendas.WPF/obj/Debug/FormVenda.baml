   M S B A M L   `   `   `  ����L  HSistemaVendas.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SistemaVendas.WPFSistemaVendas.WPF  5   	   !    SistemaVendas.WPF.FormVenda   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SistemaVendas.WPF     5   	     � Title$  Vendas��5   	   $��446.23��6   $��572.927��6(    � WindowStartupLocation$ CenterScreen=�68    � 
ResizeMode$ NoResize=�6]   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��39* �6   �� 5      $
��301* �6   .+�5   
   �� -   5         ��Name$ btnNovaVenda��5      $
��Novo��6'   $
��Left=�66   $��	31,29,0,0q�6Q   $	��Top=�6d   $��75��6|    J� RenderTransformOrigin$ 1.654,0.528&�6�   $��2��6�   �� 5   
   -   5        $ btnExcluirVenda��5      $��Excluir��6*   $
��Left=�6<   $��
158,29,0,0q�6W   $	��Top=�6k   $��75��6�   $ 1.654,0.528&�6�   $��1��6�   �� 5   
   -   5        $ btnAlterarVenda��5      $��Alterar��6*   $
��Left=�6<   $��	65,29,0,0q�6W   $	��Top=�6j   $��75��6�   $ 1.654,0.528&�6�   $��1��6�   �� 5   
   -   5         ��Name$ 
listaVenda��5       �� SelectionMode$ Single=�6'   $
��Left=�6V   $	��331��6q   $��	23,63,0,0q�6~   $	��Top=�6�   $	��517��6�   
�������$��14(�6�   $��
2147483643��6�   $��2��6  ��6>   ��  �� View 5      �� 5      .P�5      �� $��Número��6%   	 �� Width$
	 80px��65   
 �� DisplayMemberBinding
 6B   �� *Id+�� 5      $��Cliente��6%   $	 180px��66   
 6D   �� *Nome+�� 5      $
��Data��6%   $	 150px��63   
 6A   �� *Data+�� 5      $��Valor Total��6%   $
	 90px��6:   
 6G   �� *
ValorTotal+�� 5      $��
ID Cliente��6%   $		 0px��69   
 6E   �� *
Id_Cliente+5      5      5      5      