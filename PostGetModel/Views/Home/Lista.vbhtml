@Code
    ViewData("Title") = "Lista"
End Code

<h2>Lista</h2>
<div>
       <b>PessoaId</b>
</div>
<div>
    @Html.LabelFor(x=> x.Pessoaid )
</div>

<div>
    <b>Nome</b>
</div>
<div>
    @ViewData("Nome")
</div>

<div>
    <b>Twitter</b>
</div>
<div>
    @ViewData("Twitter")
</div>
<a href="~/" title="Voltar">Voltar</a>


