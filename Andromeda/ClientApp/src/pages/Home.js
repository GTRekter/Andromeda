import React, { Component } from 'react';
import Certifications from '../components/certifications/Certifications';
import Testimonials from '../components/testimonials/Testimonials';
import Education from '../components/education/Education';
import Experience from '../components/experience/Experience';
import Contacts from '../components/contacts/Contacts';
import Skills from '../components/skills/Skills';
import Slider from '../components/slider/Slider';
import About from '../components/about/About';


export class Home extends Component {
    constructor(props) {
        super(props);
        this.state = {
            info: {
                firstname: "",
                lastname: "",
                steet: "",
                city: "",
                state: "",
                zip: "",
                mobile: "",
                email: "",
                github: "",
                linkedin: "",
                twitter: "",
                facebook: "",
                position: ""
            },
            skills: [],
            experiences: [],
            educations: [],
            certifications: [],
            testimonials: []
        };
    }
    componentDidMount() {
        fetch('api/Person/GetPerson')
            .then(response => response.json())
            .then(data => {
                let info = {
                    firstname: data.person.firstName,
                    lastname: data.person.lastName,
                    street: data.person.street,
                    city: data.person.city,
                    state: data.person.state,
                    zip: data.person.zip,
                    mobile: data.person.mobile,
                    email: data.person.email,
                    github: data.person.github,
                    linkedin: data.person.linkedin,
                    twitter: data.person.twitter,
                    facebook: data.person.facebook,
                    position: data.person.position
                };
                this.setState({
                    info: info
                });
            });

        fetch('api/Skill/GetSkills')
            .then(response => response.json())
            .then(data => {
                let skills = [];
                data.skills.forEach(function (skill, i) {
                    skills.push({
                        name: skill.name,
                        proficency: skill.proficency,
                        evidence: skill.evidence
                    });
                });
                this.setState({
                    skills: skills
                });
            });

        fetch('api/Certification/GetCertifications')
            .then(response => response.json())
            .then(data => {
                let certifications = [];
                data.certifications.forEach(function (certification, i) {
                    certifications.push({
                        code: certification.code,
                        name: certification.name,
                        description: certification.description,
                        dateStart: certification.dateStart,
                        dateEnd: certification.dateEnd,
                        expirationDate: certification.expirationDate,
                        company: certification.company
                    });
                });
                this.setState({
                    certifications: certifications
                });
            });

        fetch('api/Education/GetEducations')
            .then(response => response.json())
            .then(data => {
                let educations = [];
                data.educations.forEach(function (education, i) {
                    educations.push({
                        name: education.name,
                        description: education.description,
                        fieldOfStudy: education.fieldOfStudy,
                        school: education.school,
                        dateStart: education.dateStart,
                        dateEnd: education.dateEnd,
                        country: education.country,
                        dropped: education.dropped
                    });
                });
                this.setState({
                    educations: educations
                });
            });

        fetch('api/Experience/GetExperiences')
            .then(response => response.json())
            .then(data => {
                let experiences = [];
                data.experiences.forEach(function (experience, i) {
                    experiences.push({
                        name: experience.name,
                        description: experience.description,
                        company: experience.company,
                        website: experience.website,
                        dateStart: experience.dateStart,
                        dateEnd: experience.dateEnd,
                        street: experience.street,
                        city: experience.city,
                        zip: experience.zip,
                        state: experience.state,
                        country: experience.country
                    });
                });
                this.setState({
                    experiences: experiences
                });
            });

        fetch('api/Testimonial/GetTestimonials')
            .then(response => response.json())
            .then(data => {
                let testimonials = [];
                data.testimonials.forEach(function (testimonial, i) {
                    testimonials.push({
                        firstname: testimonial.firstName,
                        middlename: testimonial.middleName,
                        lastname: testimonial.lastName,
                        testimony: testimonial.testimony,
                        position: testimonial.position,
                        company: testimonial.company
                    });
                });
                this.setState({
                    testimonials: testimonials
                });
            });
    }
    render() {
        return (
            <div data-element-id="page-home">
                <Slider info={this.state.info} />
                <About info={this.state.info} />
                <Skills skills={this.state.skills} />
                <Certifications certifications={this.state.certifications} />
                <Education educations={this.state.educations} />
                <Experience experiences={this.state.experiences} />
                <Testimonials testimonials={this.state.testimonials} />
                <Contacts info={this.state.info} />
            </div>
        );
    }
}
