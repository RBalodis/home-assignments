import React, { HTMLAttributes, ReactNode } from 'react';
import classnames from 'classnames';

export interface SectionProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLElement>['className'];
}

export const Section = ({ children, className }: SectionProps) => {
    return (
        <section className={classnames('if section', className)}>
            {children}
        </section>
    );
};
