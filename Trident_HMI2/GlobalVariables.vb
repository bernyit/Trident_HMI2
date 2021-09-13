Module GlobalVariables


    Public hmiData As WORKING_DATA

    Structure WORKING_DATA
        Dim CoilId As String
        Dim meter As Integer
        Dim measureInt1 As Int16
        Dim measureInt2 As Int16
        Dim measureInt3 As Int16
        Dim measureInt4 As Int16
        Dim measureInt5 As Int16
        Dim measureInt6 As Int16
        Dim measureInt7 As Int16
        Dim measureInt8 As Int16
        Dim measureInt9 As Int16
        Dim measureInt10 As Int16
        Dim measureInt11 As Int16
        Dim measureInt12 As Int16
        Dim measureInt13 As Int16
        Dim measureInt14 As Int16
        Dim measureInt15 As Int16
        Dim measureInt16 As Int16
        Dim measureInt17 As Int16
        Dim measureInt18 As Int16
        Dim measureInt19 As Int16
        Dim measureInt20 As Int16
        Dim measureInt21 As Int16
        Dim measureInt22 As Int16
        Dim measureInt23 As Int16
        Dim measureInt24 As Int16
        Dim measureInt25 As Int16
        Dim measureInt26 As Int16
        Dim measureInt27 As Int16
        Dim measureInt28 As Int16
        Dim measureInt29 As Int16
        Dim measureInt30 As Int16

        Dim MeasureReal1 As Decimal
        Dim MeasureReal2 As Decimal
        Dim MeasureReal3 As Decimal
        Dim MeasureReal4 As Decimal
        Dim MeasureReal5 As Decimal
        Dim MeasureReal6 As Decimal
        Dim MeasureReal7 As Decimal
        Dim MeasureReal8 As Decimal
        Dim MeasureReal9 As Decimal
        Dim MeasureReal10 As Decimal
        Dim MeasureReal11 As Decimal
        Dim MeasureReal12 As Decimal
        Dim MeasureReal13 As Decimal
        Dim MeasureReal14 As Decimal
        Dim MeasureReal15 As Decimal
        Dim MeasureReal16 As Decimal
        Dim MeasureReal17 As Decimal
        Dim MeasureReal18 As Decimal
        Dim MeasureReal19 As Decimal
        Dim MeasureReal20 As Decimal
        Dim MeasureReal21 As Decimal
        Dim MeasureReal22 As Decimal
        Dim MeasureReal23 As Decimal
        Dim MeasureReal24 As Decimal
        Dim MeasureReal25 As Decimal
        Dim MeasureReal26 As Decimal
        Dim MeasureReal27 As Decimal
        Dim MeasureReal28 As Decimal
        Dim MeasureReal29 As Decimal
        Dim MeasureReal30 As Decimal

        Dim measureWord1 As strPhotocells
        Dim measureWord2 As UInt16
        Dim measureWord3 As UInt16
        Dim measureWord4 As UInt16
        Dim measureWord5 As UInt16
        Dim measureWord6 As UInt16
        Dim measureWord7 As UInt16
        Dim measureWord8 As UInt16
        Dim measureWord9 As UInt16
        Dim measureWord10 As UInt16
        Dim measureWord11 As UInt16
        Dim measureWord12 As UInt16
        Dim measureWord13 As UInt16
        Dim measureWord14 As UInt16
        Dim measureWord15 As UInt16
        Dim measureWord16 As UInt16
        Dim measureWord17 As UInt16
        Dim measureWord18 As UInt16
        Dim measureWord19 As UInt16
        Dim measureWord20 As UInt16
        Dim measureWord21 As UInt16
        Dim measureWord22 As UInt16
        Dim measureWord23 As UInt16
        Dim measureWord24 As UInt16
        Dim measureWord25 As UInt16
        Dim measureWord26 As UInt16
        Dim measureWord27 As UInt16
        Dim measureWord28 As UInt16
        Dim measureWord29 As UInt16
        Dim measureWord30 As UInt16


    End Structure


    Structure strPhotocells
        Dim ph01 As Boolean
        Dim ph02 As Boolean
        Dim ph03 As Boolean
        Dim ph04 As Boolean
        Dim ph05 As Boolean
        Dim ph06 As Boolean
        Dim ph07 As Boolean
        Dim ph08 As Boolean
        Dim ph09 As Boolean
        Dim ph10 As Boolean
        Dim ph11 As Boolean
        Dim ph12 As Boolean
        Dim Spare13 As Boolean
        Dim Spare14 As Boolean
        Dim Spare15 As Boolean
        Dim Spare16 As Boolean
        Dim Spare17 As Boolean
        Dim Spare18 As Boolean
        Dim Spare19 As Boolean
        Dim Spare20 As Boolean
        Dim Spare21 As Boolean
        Dim Spare22 As Boolean
        Dim Spare23 As Boolean
        Dim Spare24 As Boolean
        Dim Spare25 As Boolean
        Dim Spare26 As Boolean
        Dim Spare27 As Boolean
        Dim Spare28 As Boolean
        Dim Spare29 As Boolean
        Dim Spare30 As Boolean
        Dim Spare31 As Boolean
        Dim Spare32 As Boolean
    End Structure


    Public Function intToStrPhotocells(ByVal number As UInt16) As strPhotocells

        Dim retVal As strPhotocells

        retVal.ph01 = number And 1
        retVal.ph02 = number And 2
        retVal.ph03 = number And 4
        retVal.ph04 = number And 8
        retVal.ph05 = number And 16
        retVal.ph06 = number And 32
        retVal.ph07 = number And 64
        retVal.ph08 = number And 128
        retVal.ph09 = number And 256
        retVal.ph10 = number And 512
        retVal.ph11 = number And 1024
        retVal.ph12 = number And 2048
        retVal.Spare13 = 0
        retVal.Spare14 = 0
        retVal.Spare15 = 0
        retVal.Spare16 = 0
        retVal.Spare17 = 0
        retVal.Spare18 = 0
        retVal.Spare19 = 0
        retVal.Spare20 = 0
        retVal.Spare21 = 0
        retVal.Spare22 = 0
        retVal.Spare23 = 0
        retVal.Spare24 = 0
        retVal.Spare25 = 0
        retVal.Spare26 = 0
        retVal.Spare27 = 0
        retVal.Spare28 = 0
        retVal.Spare29 = 0
        retVal.Spare30 = 0
        retVal.Spare31 = 0
        retVal.Spare32 = 0

        Return retVal
    End Function


End Module
