   M S B A M L   `   `   `  ����L  HSistemaVendas.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SistemaVendas.WPFSistemaVendas.WPF  5   	   '    !SistemaVendas.WPF.FormProdutoNovo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   X TXceed.Wpf.Toolkit, Version=3.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wpfx)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   +localclr-namespace:SistemaVendas.WPF  5   	     � Title$  Cadastro de Produto��5	   	   $��214.831��6%   $��319.703��66    � WindowStartupLocation$ CenterScreen=�6F    � 
ResizeMode$ NoResize=�6k   .��5
      � .+�5   
   ��  �� TextAlignment$ Right=�6   $
��Left=�6*   $��0,23,0,0q�6E   $
��Wrap=�6W   $��Produto:��6k   $	��Top=�6{   $��78��6�   �� 5   
   $ Right=�6   $
��Left=�6*   $��0,64,0,0q�6E   $
��Wrap=�6W   $��Quantidade:��6k   $	��Top=�6~   $��78��6�   �� 5   
   $ Right=�6   $
��Left=�6*   $��
167,67,0,0q�6E   $
��Wrap=�6Y   $��Valor:��6m   $	��Top=�6{    J� RenderTransformOrigin$ 6.521,-3.353&�6�   �� 5   
   $ Right=�6   $
��Left=�6*   $��
26,100,0,0q�6E   $
��Wrap=�6Y   $��Código:��6m   $	��Top=�6|   $��52��6�   �� 5   
   -   5         ��Name$ textDescricao��5       �� 	MaxLength$ 50��6)    �� MaxLines$ 1��68   $
��Left=�6E   $��23��6`   $��	83,23,0,0q�6l    �� TextWrapping$
 Wrap=�6   $	��Top=�6�   $	��183��6�   	 �� 	UndoLimit$	 30��6�   �� 5   
   -   5        $ textQuantidade��5      $
��Left=�6*   $��23��6E   $��	83,64,0,0q�6Q   $
 Wrap=�6d   $	��Top=�6x   $��65��6�   $	 18��6�   $ 3��6�   $ 1��6�   %  Xceed.Wpf.Toolkit.MaskedTextBox  5   
   -   5        
  Name$
 	textValor��5      $
��Left=�60   $��23��6K   $��
205,64,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $��61��6�   �� 5   
   -   5        $ 
textCodigo��5      $
��Left=�6&   $��23��6A   $��	83,99,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   $��50��6�   {�.  6�   �� 5   
   -   5         ��Name$ 	btnSalvar��5      $��Salvar��6$   $
��Left=�65   $��
83,134,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $ btnCancelar��5      $��Cancelar��6&   $
��Left=�69   $��191,134,0,0q�6T   $	��Top=�6i   $��75��6�   6�   5      5      