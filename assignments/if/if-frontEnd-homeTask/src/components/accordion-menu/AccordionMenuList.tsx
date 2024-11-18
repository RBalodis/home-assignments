import React, { HTMLAttributes, ReactNode } from 'react';
import classnames from 'classnames';

export interface AccordionMenuListProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLUListElement>['className'];
    isOpen?: boolean;
}

export const AccordionMenuList = ({
    children,
    className,
    isOpen,
}: AccordionMenuListProps) => {
    return (
        <ul
            className={classnames('if', className, {
                'is-open': isOpen,
            })}
        >
            {children}
        </ul>
    );
};
