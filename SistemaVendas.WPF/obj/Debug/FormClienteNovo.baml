   M S B A M L   `   `   `  ����L  HSistemaVendas.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SistemaVendas.WPFSistemaVendas.WPF  5   	   '    !SistemaVendas.WPF.FormClienteNovo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SistemaVendas.WPF     5   	     � Title$  Cadastro de Cliente��5   	   $	��300��6%   $��345.763��62    � WindowStartupLocation$ CenterScreen=�6B    � 
ResizeMode$ NoResize=�6g   .��5	      � .+�5
   
   ��  �� TextAlignment$ Right=�6   $
��Left=�6*   $��	16,23,0,0q�6E   $
��Wrap=�6X   $��Nome:��6l   $	��Top=�6y   $��44��6�   �� 5   
   $ Right=�6   $
��Left=�6*   $��	16,64,0,0q�6E   $
��Wrap=�6X   $��Cidade:��6l   $	��Top=�6{   $��44��6�   �� 5   
   $ Right=�6   $
��Left=�6*   $��
263,61,0,0q�6E   $
��Wrap=�6Y   $	��UF:��6m   $	��Top=�6x    J� RenderTransformOrigin$ 6.521,-3.353&�6�   �� 5   
   $ Right=�6   $
��Left=�6*   $��	8,150,0,0q�6E   $
��Wrap=�6X   $��Código:��6l   $	��Top=�6{   $��52��6�   �� 5   
   $ Right=�6   $
��Left=�6*   $��	8,110,0,0q�6E   $
��Wrap=�6X   $��
Endereço:��6l   $	��Top=�6}   $��52��6�   �� 5   
   -   5         ��Name$ textNome��5      $
��Left=�6$   $��23��6?   $��	65,22,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��263��6�    �� 	UndoLimit$ 30��6�   �� 5   
   -   5        $ 
textCidade��5      $
��Left=�6&   $��23��6A   $��	64,60,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   $	��194��6�   $ 18��6�   �� 5   
   -   5        $ textUF��5       �� 	MaxLength$ 2��6"   $
��Left=�60   $��23��6K   $��
285,60,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $��37��6�   $ 2��6�   �� 5   
   -   5        $ textEndereco��5      $
��Left=�6(   $��23��6C   $��
64,106,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��264��6�   $ 30��6�   �� 5   
   -   5        $ 
textCodigo��5      $
��Left=�6&   $��23��6A   $��
65,149,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $��50��6�   {�.  6�   �� 5   
   -   5        	 ��Name$	 	btnSalvar��5      $��Salvar��6$   $
��Left=�65   $��
40,216,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $	 btnCancelar��5      $��Cancelar��6&   $
��Left=�69   $��183,216,0,0q�6T   $	��Top=�6i   $��75��6�   6�   5      5      