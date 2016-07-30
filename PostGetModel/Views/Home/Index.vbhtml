@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>
<form action="Home/Lista" method="post">
    <fieldset>
        <legend>Pessoa</legend>
        <div>
            <input type="number" value="@Model.pessoaid" id="PessoaId" name="Pessoaid"/>
        </div>
        <div>
            <input type="text" value="@Model.nome" id="Nome" name="Nome" />
        </div>

        <div>
            <input type="text" value="@Model.twitter" id="Twitter" name="Twitter" />
        </div>

        <p><input type="submit" value="Enviar" /></p>

    </fieldset>

</form>