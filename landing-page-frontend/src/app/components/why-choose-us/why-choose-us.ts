import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-why-choose-us',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './why-choose-us.html',
  styleUrl: './why-choose-us.scss'
})
export class WhyChooseUsComponent {
  stats = [
    {
      icon: 'fas fa-project-diagram',
      number: '500+',
      label: 'Projects Completed'
    },
    {
      icon: 'fas fa-users',
      number: '300+',
      label: 'Happy Clients'
    },
    {
      icon: 'fas fa-award',
      number: '15+',
      label: 'Years Experience'
    },
    {
      icon: 'fas fa-star',
      number: '98%',
      label: 'Client Satisfaction'
    }
  ];
}
