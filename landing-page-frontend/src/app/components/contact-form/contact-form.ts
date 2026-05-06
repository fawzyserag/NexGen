import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { ContactService } from '../../services/contact';

@Component({
  selector: 'app-contact-form',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './contact-form.html',
  styleUrl: './contact-form.scss'
})
export class ContactFormComponent {
  contactForm: FormGroup;
  isSubmitting = false;
  successMessage = '';
  errorMessage = '';

  constructor(
    private fb: FormBuilder,
    private contactService: ContactService
  ) {
    this.contactForm = this.fb.group({
      name: ['', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(100)
      ]],
      email: ['', [
        Validators.required,
        Validators.email,
        Validators.maxLength(100)
      ]],
      message: ['', [
        Validators.required,
        Validators.minLength(10),
        Validators.maxLength(1000)
      ]]
    });
  }

  // Getter methods for easy access in template
  get name() {
    return this.contactForm.get('name');
  }

  get email() {
    return this.contactForm.get('email');
  }

  get message() {
    return this.contactForm.get('message');
  }

  // Check if field should show error
  shouldShowError(fieldName: string): boolean {
    const field = this.contactForm.get(fieldName);
    return !!(field && field.invalid && (field.touched || field.dirty));
  }

  // Get character count for message
  getMessageCharCount(): number {
    return this.message?.value?.length || 0;
  }

  // Check if message is approaching limit
  isApproachingLimit(): boolean {
    return this.getMessageCharCount() > 900;
  }

  onSubmit() {
    if (this.contactForm.valid) {
      this.isSubmitting = true;
      this.successMessage = '';
      this.errorMessage = '';

      this.contactService.sendMessage(this.contactForm.value).subscribe({
        next: (response) => {
          this.isSubmitting = false;
          this.successMessage = "Message sent successfully! We'll get back to you soon.";
          this.contactForm.reset();

          // Auto-hide after 4 seconds
          setTimeout(() => {
            this.successMessage = '';
          }, 4000);
        },
        error: (error) => {
          this.isSubmitting = false;
          this.errorMessage = 'Something went wrong. Please try again.';

          // Auto-hide after 4 seconds
          setTimeout(() => {
            this.errorMessage = '';
          }, 4000);
        }
      });
    } else {
      // Mark all fields as touched to show validation errors
      Object.keys(this.contactForm.controls).forEach(key => {
        this.contactForm.get(key)?.markAsTouched();
      });
    }
  }
}
