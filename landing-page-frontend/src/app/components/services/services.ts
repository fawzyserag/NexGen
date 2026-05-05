import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-services',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './services.html',
  styleUrl: './services.scss'
})
export class ServicesComponent {
  services = [
    {
      icon: 'fas fa-code',
      title: 'Custom Software Development',
      description: 'Tailored software solutions built to meet your specific business requirements and scale with your growth.'
    },
    {
      icon: 'fas fa-mobile-alt',
      title: 'Mobile App Development',
      description: 'Native and cross-platform mobile applications that deliver exceptional user experiences on iOS and Android.'
    },
    {
      icon: 'fas fa-cloud',
      title: 'Cloud Solutions',
      description: 'Secure and scalable cloud infrastructure design, migration, and management for optimal performance.'
    },
    {
      icon: 'fas fa-shield-alt',
      title: 'Cybersecurity Services',
      description: 'Comprehensive security solutions to protect your digital assets and ensure compliance with industry standards.'
    }
  ];
}
