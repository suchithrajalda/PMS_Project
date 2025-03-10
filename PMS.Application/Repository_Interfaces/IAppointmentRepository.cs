﻿using PMS.Domain.Entities;

namespace PMS.Application.Repository_Interfaces
{
    public interface IAppointmentRepository
    {
        Task<Appointment> ScheduleAppointment(Appointment appointment);
        Task<Appointment> GetAppointment(int appointmentId);
        Task<Appointment> UpdateAppointment(int appointmentId, Appointment appointment);
        Task<List<Appointment>> GetAppointmentsByPatientId(int patientId);
        Task<List<Appointment>> GetAppointmentsByDoctorId(int doctorId);

    }
}
