   M S B A M L   `   `   `  ����L  HSistemaVendas.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SistemaVendas.WPFSistemaVendas.WPF  5   	   N JSistemaVendas.Banco, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:SistemaVendas.Banco;assembly=SistemaVendas.BancoSistemaVendas.Banco 5   	   #    SistemaVendas.WPF.FormCliente   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SistemaVendas.WPF     5   	   PBanco>clr-namespace:SistemaVendas.Banco;assembly=SistemaVendas.Banco     5   	     � Title$  Clientes��5	   	   $��321.61��6   $��679.268��6*    � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ NoResize=�6_   .��5
      � .+�5   
   �� -   5         ��Name$ btnClienteNovo��5      $
��Novo��6)   $
��Left=�68   $��	10,29,0,0q�6S   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $ btnClienteExcluir��5      $��Excluir��6,   $
��Left=�6>   $��
203,29,0,0q�6Y   $	��Top=�6m   $��75��6�    J� RenderTransformOrigin$ 1.654,0.528&�6�   6�   �� 5   
   -   5        $ btnClienteAlterar��5      $��Alterar��6,   $
��Left=�6>   $��
108,29,0,0q�6Y   $	��Top=�6m   $��75��6�   $ 1.654,0.528&�6�   6�   �� 5   
   -   5         ��Name$ listaCliente��5       �� SelectionMode$ Single=�6)   $
��Left=�6X   $	��216��6s   $��	10,63,0,0q�6�   $	��Top=�6�   $	��650��6�   
�������$��14(�6�   $��
2147483643��6�   ��6@   ��  �� View 5      �� 5      .P�5      �� $��Código��6%    �� Width$
 50px��65   	 �� DisplayMemberBinding	 6B   �� *Id+�� 5      $
��Nome��6%   $ 200px��63   	 6A   �� *Nome+�� 5      $��Endereco��6%   $ 200px��67   	 6E   �� *
Endereco+�� 5      $��Cidade��6%   $ 140px��65   	 6C   �� *Cidade+�� 5      $��UF��6%   $
 50px��61   	 6>   �� *Uf+5      5      5      5      