# SharpPontoMais

SharpPontoMais é uma implementação da API da Ponto Mais em C# usando .NET Standard.

Para começar a usar você primeiro precisa solicitar um Token na sua conta da PontoMais.

A Documentação da API está em dentro do painel da Ponto Mais

############################ WORK IN PROGRESS #####################################

Alguns dos metodos já estão implementados porem ainda sem testes, para usar é só seguir o exemplo abaixo.

                using (var pontoMais = new ServicesPontoMais(tokenPontoMais))
                {
                    var colaborador = new ColaboradorToSet
                    {
                        admission_date = usuario.data_adimissao,
                        cost_center_id = cost_center_id,
                        cpf = usuario.cpf,
                        email = usuario.email,
                        has_time_cards = has_time_cards,
                        initial_date = DateTime.Now,
                        is_clt = true,
                        job_title_id = job_title_id,
                        name = usuario.nome,
                        nis = usuario.pis,
                        registration_number = usuario.id,
                        shift_id = shift_id,
                        team_id = team_id,
                        time_card_source = (TimeCardSource)time_card_source
                    };

                    pontoMais.AtualizaColaborador(colaborador, usuario.USUA_PONTOMAIS_ID.Value);
                }
            
            
Todos os metodos estão dentro de PontoMais.API.ServicesPontoMais e os Modelos estão em PontoMais.API.Models.

Espero estar ajudando.
