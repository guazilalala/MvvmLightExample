   M S B A M L   `   `   `  ����K  GMvvmLightExample, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null=#clr-namespace:MvvmLightExample.ViewMvvmLightExample.View  5   	   /    )MvvmLightExample.View.BindingAdvancedView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:MvvmLightExample.View     5   	     � Title$  BindingAdvancedView��5   	   $	��800��6%   $	��600��62    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5	   	   ��    Locator �� Source# [   �� Path$ BindingAdvanced�.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��0��6   $��	下拉框��6    $��3,3,3,10q�6-   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��200��6   $
��Left=�6'    �� DisplayMemberPath$
 Text��5       �� SelectedValuePath$	 Key��64   ��5      �� *CombboxList+	 �� SelectedItem	 5      �� *	Combbox+5      �� 5      $	��100��6   $��20,0,0,0q�6(   ��6:   �� *Combbox.Text+
 �� StringFormat$
 
结果:{0}��6q   5      5      �� 5   
   $��1��6   $��	单选框��6    $��3,3,3,10q�6-   .��5      �� $ 
Horizontal=�6   .+�5      	� $	��200��6g   ��6   �� *SingleRadio+ d� 	IsChecked 6>   �� *IsSingleRadioCheck+6u   �� 5      $��20,0,0,0q�6   ��6.   �� *IsSingleRadioCheck+$
 
结果:{0}��6k   5       5!      �� 5"   
   $��2��6   $��组合单选框��6    $��3,3,3,10q�6/   .��5#      ]� -   5         ]�Name$ GroupRadioButton��5#      .+�5$      �� $ 
Horizontal=�6   .+�5%      �� $	��200��6H   ��6#   �� *RadioButtons+��5&      �� 5'      .R�5(   "   	�  	� 	GroupName$ RadioButtons��6h   ��6.   �� *	Content+ 6J   �� *	IsCheck+��5)   2   �� *DataContext.RadioCheckCommand+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ ItemsControlL�5*   #   5+      5-      �� 5.      $��20,0,0,0q�6    ��62   �� *RadioButton.Content+$
 
结果:{0}��6p   5/      50      51      52      53      