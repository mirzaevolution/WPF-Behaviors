   M S B A M L   `   `   `  ����O  KImplicitDataTemplate, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:ImplicitDataTemplate.EmployeeDetail#ImplicitDataTemplate.EmployeeDetail  5      8    2ImplicitDataTemplate.EmployeeDetail.EmployeeDetail   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:ImplicitDataTemplate.EmployeeDetail     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  6S   .  (System.Windows.Interactivity.Interaction    Triggers  5
      /  )System.Windows.Interactivity.EventTrigger  5   
   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      >  8Microsoft.Expression.Interactivity.Core.CallMethodAction     
MethodName$ GetData��6G      TargetObject 6"   ��  �� Mode$ OneWay=�6G   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��
First Name��6   $��10q�6&   �� 5   
   $��1��6   $��10q�6F    �� 
IsReadOnly . ��6"   �� *Employee.FirstName+6R   �� 5   
   $��1��6   $��	Last Name��6!   $��10q�62   �� 5   
   $��1��6   $��1��6   $��10q�6R    . ��6/   �� *Employee.LastName+6^   �� 5   
   $��2��6   $	��Job��6!   $��10q�6,   �� 5    
   $��2��6   $��1��6   $��10q�6M    . ��6/   �� *Employee.Job+6Y   �� 5!   
   $��3��6   $��Date Accepted��6!   $��10q�66   (  "System.Windows.Controls.DatePicker  5"   
   $��3��6   $��1��6"   $��10q�6a      SelectedDate 62   �� *Employee.DateAccepted+6a   �� 5#   
   $��4��6   $��1��6   $
��Back��6.   $��80��6=   $��25��6H   $��Right=�5$   7   $��10q�6S   ��6   �� *BackToMainCommand+6S   5&      5'      