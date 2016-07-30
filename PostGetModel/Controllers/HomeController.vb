Public Class HomeController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Home

    Function Index() As ActionResult

        Dim pess As New Pessoa
        pess.Nome = "Angelo"
        pess.pessoaid = 1
        pess.Twitter = "www.upandaway.pt"

        Return View(pess)
    End Function

    Function Lista(pessoa As Pessoa) As ActionResult


        Return View(pessoa)

    End Function

End Class