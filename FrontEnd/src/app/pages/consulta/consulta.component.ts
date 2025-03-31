import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ApiService } from '../../services/api.service';

@Component({
  selector: 'app-consulta',
  standalone: true, 
  imports: [CommonModule, FormsModule], 
  templateUrl: './consulta.component.html',
  styleUrls: ['./consulta.component.css'] 
})
export class ConsultaComponent {
  numero: number | null = null;
  resultado: string | null = null;
  loading = false;
  error: string | null = null;

  constructor(private apiService: ApiService) {}

  buscar() {
    if (!this.numero) {
      this.error = 'Por favor, informe um número válido';
      return;
    }

    this.loading = true;
    this.error = null;
    this.resultado = null;

    this.apiService.consultar(this.numero).subscribe({
      next: (res) => {
        this.resultado = res.nome; 
        this.loading = false;
      },
      error: (err) => {
        this.error = 'Erro ao buscar dados. Tente novamente.';
        this.loading = false;
        console.error('Erro na consulta:', err);
      }
    });
  }
}