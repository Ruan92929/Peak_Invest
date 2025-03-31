import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ApiService } from '../../services/api.service';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.css'],
  imports: [CommonModule, FormsModule]
})
export class CadastroComponent {
  parcelas!: number;
  valor!: number;
  resultado!: number;

  constructor(private apiService: ApiService) {}

  salvar() {
    if (this.parcelas && this.valor) {
      this.apiService.cadastrar({ parcelas: this.parcelas, valorParcela: this.valor })
        .subscribe(res => {
          this.resultado = res.valorTotal;
        }, error => {
          console.error('Erro ao salvar: ', error);
          alert('Erro ao salvar, tente novamente!');
        });
    } else {
      alert('Por favor, preencha todos os campos.');
    }
  }
}
