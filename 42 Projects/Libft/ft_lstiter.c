/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_lstiter.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/03/01 11:40:50 by mfeijao           #+#    #+#             */
/*   Updated: 2021/03/01 11:41:06 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	ft_lstiter(t_list *list, void (*f)(void *))
{
	t_list *temp;

	if (!list)
		list = NULL;
	if (f)
	{
		while (list)
		{
			temp = list->next;
			f((list)->content);
			list = temp;
		}
	}
}
