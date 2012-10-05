﻿Imports LogicaNegocio.ClsGestor
Public Class ctlBuscarAuxiliarInactivo
    Dim _gestor As New LogicaNegocio.ClsGestor
    Dim _listaAuxiliar As List(Of Array) = New List(Of Array)() 'declarar una variable tipo lista genérica de Array
    Dim _tempArray As Array 'declarar una variable tipo Array
    Dim _criterio As String
    Dim _resul As Boolean
    'declarar variables tipo
    Dim _cod As String

    Private Sub ctlBuscarAuxiliarInactivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCriterio.Focus()
        limpiarForm()
        nombrarColumnas()
    End Sub

    Private Sub txtCriterio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCriterio.TextChanged
        evaluar()
        If txtCriterio.Text = "" Then
            cargarAuxiliares()
            nombrarColumnas()
        Else
            buscarAuxiliarPorCriterio(txtCriterio.Text)
        End If
    End Sub

    Private Sub limpiarForm()
        Me.dgvDatos.DataSource = ""
        Me.txtCriterio.Text = ""
        cargarAuxiliares()
    End Sub

    Private Sub evaluar()

        If txtCriterio.Text.Equals("") Then
            cargarAuxiliares()
            nombrarColumnas()
        Else
            Me.dgvDatos.DataSource = ""
        End If

    End Sub

    ''' <summary>
    ''' Método de clase, encarga de renombrar los encabezados al datagridview
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub nombrarColumnas()
        dgvDatos.Columns(0).HeaderText = "Código"
        dgvDatos.Columns(1).HeaderText = "Identificación"
        dgvDatos.Columns(2).HeaderText = "Nombre"
        dgvDatos.Columns(3).HeaderText = "Teléfono"
        dgvDatos.Columns(2).MinimumWidth = 155
        dgvDatos.Columns(4).Visible = False
    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar los auxiliares existentes en la DB con el nombre suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub cargarAuxiliares()
        Try
            Dim _listTemp As New List(Of ClsCastCadenaAuxiliar) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaAuxiliar = _gestor.listarAuxiliaresInactivo() 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaAuxiliar.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaAuxiliar(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next

                _listTemp.Add(New ClsCastCadenaAuxiliar(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next

            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada

        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Auxiliar")
        End Try

    End Sub

    ''' <summary>
    ''' Método de clase, encargado de cargar el auxiliar existente en la DB con el id suministado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub buscarAuxiliarPorCriterio(ByVal pcriterio As String)
        Try
            Dim _listTemp As New List(Of ClsCastCadenaAuxiliar) 'declarar una variable tipo lista genérica tipo clsCastCadena (Wrapper)
            Dim _tempCast() As String 'declarar una variable tipo arreglo de String

            _listaAuxiliar = _gestor.buscarAuxiliarPorCriterioInactivo(pcriterio) 'asignar el resultado de la búsqueda devuelto por un método del Gestor

            For i As Integer = 0 To _listaAuxiliar.Count - 1 'estructura iterativa tipo matriz para recorrer y envolver por el tipo adecuado

                _tempArray = _listaAuxiliar(i) 'clonar a un Array temporal la FILA (ROW) de la consulta
                ReDim _tempCast(_tempArray.Length() - 1) 'redimensionar el arreglo a un tamaño indicado

                For j As Integer = 0 To _tempArray.Length - 1 'recorrer la parte interna de la matriz, columna (COLUMN)
                    _tempCast(j) = _tempArray.GetValue(j).ToString() 'asignar el valor de cada celda 
                Next
                _listTemp.Add(New ClsCastCadenaAuxiliar(_tempCast(0).ToString(), _tempCast(1).ToString(), _tempCast(2).ToString(), _tempCast(3).ToString(), _tempCast(4).ToString())) 'agregar a la lista genérica una colección de la clase wrapper

            Next
            Me.dgvDatos.DataSource = _listTemp 'asignar el fuente de dato para un control tipo datagridview la lista genérica wrappeada
            nombrarColumnas()
        Catch ex As Exception
            MsgBox("Error en la operación ... " & ex.Message, MsgBoxStyle.Information, "Buscar Auxiliar")
        End Try
    End Sub

    Private Sub pbActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbActivar.Click
        If Not dgvDatos.RowCount = 0 Then
            _cod = Me.dgvDatos.SelectedCells(0).Value
            Dim _result As DialogResult
            _result = MessageBox.Show("¿Está seguro que desea activar el auxiliar?", "Activar Auxiliar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0, False)
            Try
                If _result = Windows.Forms.DialogResult.Yes Then
                    _gestor.ActivarAuxiliar(_cod) 'invocar el método indicado enviando los argumentos requeridos.
                    MsgBox("El auxiliar se ha activado.", MsgBoxStyle.Information, "Activar Auxiliar")
                Else
                    MsgBox("Los datos del auxiliar no se pueden activar.", MsgBoxStyle.Information, "Activar Auxiliar")
                End If
            Catch ex As Exception
                MsgBox("Los datos del auxiliar no se pueden activar." & ex.Message, MsgBoxStyle.Information, "Activar Auxiliar")
            End Try
            limpiarForm()
            nombrarColumnas()
        End If
    End Sub

    Private Sub pbRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRegresar.Click
        CType(Me.ParentForm, frmCentroAgricola).cargarUserControl(New ctlPrincipal)
    End Sub
End Class
