Imports Telerik.WinControls.UI.Localization


Public Class MyEnglishRadGridLocalizationProvider

    Inherits RadGridLocalizationProvider

    Public Overrides Function GetLocalizedString(ByVal id As String) As String
        Select Case id
            Case RadGridStringId.FilterFunctionBetween
                Return "Entre"
            Case RadGridStringId.FilterFunctionContains
                Return "Contiene"
            Case RadGridStringId.FilterFunctionDoesNotContain
                Return "No contiene"
            Case RadGridStringId.FilterFunctionEndsWith
                Return "Termina con"
            Case RadGridStringId.FilterFunctionEqualTo
                Return "Igual"
            Case RadGridStringId.FilterFunctionGreaterThan
                Return "más que"
            Case RadGridStringId.FilterFunctionGreaterThanOrEqualTo
                Return "Mayor o igual a"
            Case RadGridStringId.FilterFunctionIsEmpty
                Return "Vacío"
            Case RadGridStringId.FilterFunctionIsNull
                Return "Es nulo"
            Case RadGridStringId.FilterFunctionLessThan
                Return "menos que"
            Case RadGridStringId.FilterFunctionLessThanOrEqualTo
                Return "Menor o igual a"
            Case RadGridStringId.FilterFunctionNoFilter
                Return "Sin Filtro"
            Case RadGridStringId.FilterFunctionNotBetween
                Return "No entre"
            Case RadGridStringId.FilterFunctionNotEqualTo
                Return "No igual"
            Case RadGridStringId.FilterFunctionNotIsEmpty
                Return "No está vacío"
            Case RadGridStringId.FilterFunctionNotIsNull
                Return "No es nulo"
            Case RadGridStringId.FilterFunctionStartsWith
                Return "Comienza con"
            Case RadGridStringId.FilterFunctionCustom
                Return "Custom"


            Case RadGridStringId.CustomFilterMenuItem
                Return "Custom"
            Case RadGridStringId.CustomFilterDialogCaption
                Return "RadGridView Filter Dialog"
            Case RadGridStringId.CustomFilterDialogLabel
                Return "Show rows where:"
            Case RadGridStringId.CustomFilterDialogRbAnd
                Return "And"
            Case RadGridStringId.CustomFilterDialogRbOr
                Return "Or"
            Case RadGridStringId.CustomFilterDialogBtnOk
                Return "OK"
            Case RadGridStringId.CustomFilterDialogBtnCancel
                Return "Cancel"
          
            Case RadGridStringId.DeleteRowMenuItem
                Return "Eliminar Fila"
            Case RadGridStringId.SortAscendingMenuItem
                Return "Ordenar Ascendente"
            Case RadGridStringId.SortDescendingMenuItem
                Return "Ordenar Descendente"
            Case RadGridStringId.ClearSortingMenuItem
                Return "Borrar Filtro"
            Case RadGridStringId.ConditionalFormattingMenuItem
                Return "Formato Condicional"
            Case RadGridStringId.GroupByThisColumnMenuItem
                Return "Agrupar por esta columna"
            Case RadGridStringId.UngroupThisColumn
                Return "Desagrupar por esta columna"
            Case RadGridStringId.ColumnChooserMenuItem
                Return "Selector de Columna"
            Case RadGridStringId.HideMenuItem
                Return "Ocultar Columna"
            Case RadGridStringId.UnpinMenuItem
                Return "Liberar Columna"
         
            Case RadGridStringId.PinMenuItem
                Return "Llevar al inicio"
            Case RadGridStringId.BestFitMenuItem
                Return "Mejor Ajuste"
            Case RadGridStringId.PasteMenuItem
                Return "Paste"
            Case RadGridStringId.EditMenuItem
                Return "Edit"
            Case RadGridStringId.ClearValueMenuItem
                Return "Clear Value"
            Case RadGridStringId.CopyMenuItem
                Return "Copy"
            Case RadGridStringId.AddNewRowString
                Return "Click here to add a new row"
            Case RadGridStringId.ConditionalFormattingCaption
                Return "Conditional Formatting Rules Manager"
            Case RadGridStringId.ConditionalFormattingLblColumn
                Return "Format only cells with"
            Case RadGridStringId.ConditionalFormattingLblName
                Return "Rule name:"
            Case RadGridStringId.ConditionalFormattingLblType
                Return "Cell value:"
            Case RadGridStringId.ConditionalFormattingLblValue1
                Return "Value 1:"
            Case RadGridStringId.ConditionalFormattingLblValue2
                Return "Value 2:"
            Case RadGridStringId.ConditionalFormattingGrpConditions
                Return "Rules"
            Case RadGridStringId.ConditionalFormattingGrpProperties
                Return "Rule Properties"
            Case RadGridStringId.ConditionalFormattingChkApplyToRow
                Return "Apply this rule to entire row"
            Case RadGridStringId.ConditionalFormattingBtnAdd
                Return "Add new rule"
            Case RadGridStringId.ConditionalFormattingBtnRemove
                Return "Remove selected rule"
            Case RadGridStringId.ConditionalFormattingBtnOK
                Return "OK"
            Case RadGridStringId.ConditionalFormattingBtnCancel
                Return "Cancel"
            Case RadGridStringId.ConditionalFormattingBtnApply
                Return "Apply"
            Case RadGridStringId.ConditionalFormattingRuleAppliesOn
                Return "Rule applies on:"
            Case RadGridStringId.ConditionalFormattingChooseOne
                Return "[Choose one]"
            Case RadGridStringId.ConditionalFormattingEqualsTo
                Return "equals to [Value1]"
            Case RadGridStringId.ConditionalFormattingIsNotEqualTo
                Return "is not equal to [Value1]"
            Case RadGridStringId.ConditionalFormattingStartsWith
                Return "starts with [Value1]"
            Case RadGridStringId.ConditionalFormattingEndsWith
                Return "ends with [Value1]"
            Case RadGridStringId.ConditionalFormattingContains
                Return "contains [Value1]"
            Case RadGridStringId.ConditionalFormattingDoesNotContain
                Return "does not contain [Value1]"
            Case RadGridStringId.ConditionalFormattingIsGreaterThan
                Return "is greater than [Value1]"
            Case RadGridStringId.ConditionalFormattingIsGreaterThanOrEqual
                Return "is greater than or equal [Value1]"
            Case RadGridStringId.ConditionalFormattingIsLessThan
                Return "is less than [Value1]"
            Case RadGridStringId.ConditionalFormattingIsLessThanOrEqual
                Return "is less than or equal to [Value1]"
            Case RadGridStringId.ConditionalFormattingIsBetween
                Return "is between [Value1] and [Value2]"
            Case RadGridStringId.ConditionalFormattingIsNotBetween
                Return "is not between [Value1] and [Value1]"

            Case RadGridStringId.ColumnChooserFormCaption
                Return "Selector de Columnas"
            Case RadGridStringId.ColumnChooserFormMessage
                Return "Drag a column header from the" & vbLf & "grid here to remove it from" & vbLf & "the current view."
            Case RadGridStringId.GroupingPanelDefaultMessage
                Return "Arrastre una columna aquí para agrupar por esta columna."
            Case RadGridStringId.NoDataText
                Return "No hay Registros para la búsqueda solicitada..."
            
        End Select



        Return String.Empty
    End Function



End Class
