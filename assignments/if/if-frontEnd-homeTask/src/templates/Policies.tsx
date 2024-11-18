import React from 'react';

import { Section } from '../components/layout/Section';
import { Container } from '../components/layout/Container';

import { Policy, PolicyCard } from '../components/policy/PolicyCard';

const policies: Array<Policy> = [
    {
        title: 'Health 🏥',
    },
    {
        title: 'Car 🚔',
    },
    {
        title: 'Home 🏠',
    },
];

export const Policies = () => {
    return (
        <Section className={'dark'}>
            <Container>
                {policies.map((p, i) => (
                    <PolicyCard key={i} policy={p} />
                ))}
            </Container>
        </Section>
    );
};
