import React, { HTMLAttributes, ReactNode } from 'react';
import classnames from 'classnames';

export interface AccordionMenuProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLLIElement>['className'];
    isOpen?: boolean;
}

export const AccordionMenu = ({
    children,
    className,
    isOpen,
}: AccordionMenuProps) => {
    return (
        <div
            className={classnames('if accordion-menu', className, {
                'is-open': isOpen,
            })}
        >
            {children}
        </div>
    );
};
